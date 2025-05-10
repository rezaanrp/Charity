using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityTestCore.Tools
{
	public class csShamciToMiladi
	{
		public DateTime ShamciToMiladi(string shamci)
		{
			if (string.IsNullOrWhiteSpace(shamci))
			{
				DateTime today = DateTime.Today;
				return today;
			}
			string[] da = shamci.Split("/");
			PersianCalendar pc = new PersianCalendar();
			DateTime dt = new DateTime(int.Parse(da[0]), int.Parse(da[1]), int.Parse(da[2]), pc);
			return dt;
		}
        public static DateTime? ShamsiToMiladi(string? shamsi)
        {
            if (string.IsNullOrWhiteSpace(shamsi))
                return null; // مقدار null در صورت ورودی نامعتبر

            string[] parts = shamsi.Split('/');
            if (parts.Length != 3)
                throw new ArgumentException("فرمت تاریخ باید به صورت YYYY/MM/DD باشد.");

            try
            {
                int year = int.Parse(parts[0]);
                int month = int.Parse(parts[1]);
                int day = int.Parse(parts[2]);

                PersianCalendar pc = new PersianCalendar();
                return new DateTime(year, month, day, pc);
            }
            catch (Exception)
            {
                throw new FormatException("تاریخ وارد شده نامعتبر است.");
            }
        }
		public string MiladiToShamci(DateTime? dt)
		{
			DateTime date = dt ?? DateTime.Now;
			PersianCalendar pc = new PersianCalendar();

			if (date.Year <= 1000)
			{
				date = DateTime.Today;
			}

			return $"{pc.GetYear(date):0000}/{pc.GetMonth(date):00}/{pc.GetDayOfMonth(date):00}";
		}

		public static string? MiladiToShamsi(DateTime? dt)
		{
			if (dt == null || dt.Value.Ticks < new DateTime(622, 3, 22).Ticks)
				return null; // یا می‌تونه "" یا "تاریخ نامعتبر" باشه

			PersianCalendar pc = new PersianCalendar();

			return string.Format("{0}/{1:D2}/{2:D2}",
				pc.GetYear(dt.Value),
				pc.GetMonth(dt.Value),
				pc.GetDayOfMonth(dt.Value));
		}

	}
}
