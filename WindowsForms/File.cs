using System;
using System.Management;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace FileAssembly
{
	class File
	{
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int GetSystemMetrics(int nIndex);

		public static string ExcelFile()
		{
			var excelApp = new Excel.Application();
			excelApp.Workbooks.Add();
			Excel._Worksheet sheet = (Excel.Worksheet)excelApp.ActiveSheet;

			sheet.Range["A1", "A3"].Merge();
			sheet.Range["A7", "A8"].Merge();

			sheet.Cells[1, "A"] = "Operating system";
			sheet.Cells[4, "A"] = "Name";
			sheet.Cells[5, "A"] = "CPU";
			sheet.Cells[6, "A"] = "RAM";
			sheet.Cells[7, "A"] = "Screen";

			sheet.Cells[1, "B"] = "Caption";
			sheet.Cells[2, "B"] = "Version";
			sheet.Cells[3, "B"] = "Architecture";
			sheet.Cells[7, "B"] = "Width";
			sheet.Cells[8, "B"] = "Height";

			sheet.Cells[1, "C"] = GetInfo.GetComponent("Win32_OperatingSystem", "Caption");
			sheet.Cells[2, "C"] = GetInfo.GetComponent("Win32_OperatingSystem", "Version");
			sheet.Cells[3, "C"] = GetInfo.GetComponent("Win32_OperatingSystem", "OSArchitecture");
			sheet.Cells[4, "C"] = Environment.MachineName.ToString();
			sheet.Cells[5, "C"] = GetInfo.GetComponent("Win32_Processor", "Name");
			sheet.Cells[6, "C"] = GetInfo.GetRAM("CIM_PhysicalMemory", "Capacity") + "MB";
			sheet.Cells[7, "C"] = GetSystemMetrics(0);
			sheet.Cells[8, "C"] = GetSystemMetrics(1);


			sheet.Range["B1", "B8"].BorderAround2(Excel.XlLineStyle.xlContinuous);
			sheet.Range["A1", "C3"].BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
			sheet.Range["A4", "C4"].BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
			sheet.Range["A5", "C5"].BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
			sheet.Range["A6", "C6"].BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
			sheet.Range["A7", "C8"].BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

			sheet.Range["A1", "C8"].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
			sheet.Range["A1", "C8"].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
			sheet.Range["A1", "C8"].Font.Size = 14;
			sheet.Range["A1", "C8"].Columns.AutoFit();

			excelApp.DisplayAlerts = false;

			string path = Environment.CurrentDirectory + "\\Specifications.xlsx";
			sheet.SaveAs(path, Excel.XlFileFormat.xlWorkbookDefault,
						Missing.Value, Missing.Value, false, false, true,
						Missing.Value, Missing.Value, Missing.Value);

			excelApp.Quit();

			return path;
		}
	}

	internal class GetInfo
	{
		public static string GetComponent(string hwclass, string syntax)
		{
			ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);

			foreach (ManagementObject mo in mos.Get())
			{
				return Convert.ToString(mo[syntax]);
			}

			return "";
		}

		public static ulong GetRAM(string hwclass, string syntax)
		{
			ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
			ulong ram = 0;

			foreach (ManagementObject mo in mos.Get())
			{
				ram += Convert.ToUInt64(mo[syntax]);
			}

			return ram / 1024 / 1024;
		}
	}
}