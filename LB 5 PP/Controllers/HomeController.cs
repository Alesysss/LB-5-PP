using LB_5_PP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace LB_5_PP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



		private int min1 = 0;
		private int min2 = 0;
		private int min3 = 0;
		private int max1 = 0;
		private int max2 = 0;
		private int max3 = 0;
		
		private float Yf1 = 0;
		private float Yf2 = 0;
		private float Yf3 = 0;
		private float Yf4 = 0;
		private float Yf5 = 0;
		float t = 0;

		public IActionResult TaskFirst()
		{
			return View();
		}

		public IActionResult TaskSecond()
		{
			return View();
		}

		public IActionResult TaskThird()
		{
			return View();
		}

		

		private int time = 0;
		[HttpPost]
		
		public IActionResult TaskFirst(string One, string Two, string Three, string Four)
		{
			

			float one = float.Parse(One, System.Globalization.CultureInfo.InvariantCulture);
			if (one < 0)
			{
				time++;
			}

			float two = float.Parse(Two, System.Globalization.CultureInfo.InvariantCulture);
			if (two < 0)
			{
				time++;
			}

			float three = float.Parse(Three, System.Globalization.CultureInfo.InvariantCulture);
			if (three < 0)
			{
				time++;
			}

			float four = float.Parse(Four, System.Globalization.CultureInfo.InvariantCulture);
			if (four < 0)
			{
				time++;
			}

			ViewBag.H = time;
			return View();
		}

		[HttpPost]

		

		public IActionResult TaskSecond(string OneSbOneSr, string TwoSbOneSr, string ThreeSbOneSr, string OneSbTwoSr, string TwoSbTwoSr, string ThreeSbTwoSr, string OneSbThreeSr, string TwoSbThreeSr, string ThreeSbThreeSr)
		{
			int _OneSbOneSr = Convert.ToInt32(OneSbOneSr);
			int _TwoSbOneSr = Convert.ToInt32(TwoSbOneSr);
			int _ThreeSbOneSr = Convert.ToInt32(ThreeSbOneSr);
			int _OneSbTwoSr = Convert.ToInt32(OneSbTwoSr);
			int _TwoSbTwoSr = Convert.ToInt32(TwoSbTwoSr);
			int _ThreeSbTwoSr = Convert.ToInt32(ThreeSbTwoSr);
			int _OneSbThreeSr = Convert.ToInt32(OneSbThreeSr);
			int _TwoSbThreeSr = Convert.ToInt32(TwoSbThreeSr);
			int _ThreeSbThreeSr = Convert.ToInt32(ThreeSbThreeSr);

			// мин 1 стлб
			if (_OneSbOneSr<=_OneSbTwoSr)
			{
				min1= _OneSbOneSr;
				if(_OneSbOneSr<= _OneSbThreeSr)
				{
					min1 = _OneSbOneSr;
				}
				else { min1 = _OneSbThreeSr; }
			}
			else 
			{
				min1 = _OneSbTwoSr; 
				if(_OneSbTwoSr<= _OneSbThreeSr)
				{ min1 = _OneSbTwoSr;}
				else { min1 = _OneSbThreeSr; }
			}
			@ViewBag.MinSbOne=min1;

			//мин 2 стлб
			if (_TwoSbOneSr <= _TwoSbTwoSr)
			{
				min2 = _TwoSbOneSr;
				if (_TwoSbOneSr <= _TwoSbThreeSr)
				{
					min2 = _TwoSbOneSr;
				}
				else { min2 = _TwoSbThreeSr; }
			}
			else
			{
				min2 = _TwoSbTwoSr;
				if (_TwoSbTwoSr <= _TwoSbThreeSr)
				{ min2 = _TwoSbTwoSr; }
				else { min2 = _TwoSbThreeSr; }
			}
			@ViewBag.MinSbTwo=min2;

			//мин 3 стлб
			if (_ThreeSbOneSr <= _ThreeSbTwoSr)
			{
				min3 = _ThreeSbOneSr;
				if (_ThreeSbOneSr <= _ThreeSbThreeSr)
				{
					min3 = _ThreeSbOneSr;
				}
				else { min3 = _ThreeSbThreeSr; }
			}
			else
			{
				min3 = _ThreeSbTwoSr;
				if (_ThreeSbTwoSr <= _ThreeSbThreeSr)
				{ min3 = _ThreeSbTwoSr; }
				else { min3 = _ThreeSbThreeSr; }
			}
			@ViewBag.MinSbThree=min3;

			//макс 1 стр
			if (_OneSbOneSr >= _TwoSbOneSr)
			{
				max1 = _OneSbOneSr;
				if (_OneSbOneSr >= _ThreeSbOneSr)
				{
					max1 = _OneSbOneSr;
				}
				else { max1 = _ThreeSbOneSr; }
			}
			else
			{
				max1 = _TwoSbOneSr;
				if (_TwoSbOneSr >= _ThreeSbOneSr)
				{ max1 = _TwoSbOneSr; }
				else { max1 = _ThreeSbOneSr; }
			}
			@ViewBag.MaxSrOne=max1;

			//макс 2 стр
			if (_OneSbTwoSr >= _TwoSbTwoSr)
			{
				max2 = _OneSbTwoSr;
				if (_OneSbTwoSr >= _ThreeSbTwoSr)
				{
					max2 = _OneSbTwoSr;
				}
				else { max2 = _ThreeSbTwoSr; }
			}
			else
			{
				max2 = _TwoSbTwoSr;
				if (_TwoSbTwoSr >= _ThreeSbTwoSr)
				{ max2 = _TwoSbTwoSr; }
				else { max2 = _ThreeSbTwoSr; }
			}
			@ViewBag.MaxSrTwo=max2;

			//макс 3 стр
			if (_OneSbThreeSr >= _TwoSbThreeSr)
			{
				max3 = _OneSbThreeSr;
				if (_OneSbThreeSr >= _ThreeSbThreeSr)
				{
					max3 = _OneSbThreeSr;
				}
				else { max3 = _ThreeSbThreeSr; }
			}
			else
			{
				max3 = _TwoSbThreeSr;
				if (_TwoSbThreeSr >= _ThreeSbThreeSr)
				{ max3	 = _TwoSbThreeSr; }
				else { max3 = _ThreeSbThreeSr; }
			}
			@ViewBag.MaxSrThree=max3;

		return View();
		}
		[HttpPost]

		public IActionResult TaskThird (string OneSbOneSr, string OneSbTwoSr, string OneSbThreeSr, string OneSbFourSr, string OneSbFiveSr,
			string TwoSbOneSr, string TwoSbTwoSr, string TwoSbThreeSr, string TwoSbFourSr, string TwoSbFiveSr,
			string ThreeSbOneSr, string ThreeSbTwoSr, string ThreeSbThreeSr, string ThreeSbFourSr, string ThreeSbFiveSr,
			string FourSbOneSr, string FourSbTwoSr, string FourSbThreeSr, string FourSbFourSr, string FourSbFiveSr,
			string FiveSbOneSr, string FiveSbTwoSr, string FiveSbThreeSr, string FiveSbFourSr, string FiveSbFiveSr)
		{
			//1 стлб
			float Sb1Sr1 = float.Parse(OneSbOneSr, System.Globalization.CultureInfo.InvariantCulture);
			float Sb1Sr2 = float.Parse(OneSbTwoSr, System.Globalization.CultureInfo.InvariantCulture);
			float Sb1Sr3 = float.Parse(OneSbThreeSr, System.Globalization.CultureInfo.InvariantCulture);
			float Sb1Sr4 = float.Parse(OneSbFourSr, System.Globalization.CultureInfo.InvariantCulture);
			float Sb1Sr5 = float.Parse(OneSbFiveSr, System.Globalization.CultureInfo.InvariantCulture);

			if (Sb1Sr1 <= Sb1Sr2)
			{
				Yf1 = Sb1Sr1;
				if (Sb1Sr1 <= Sb1Sr3)
				{
					Yf1 = Sb1Sr1;
					if (Sb1Sr1 <= Sb1Sr4)
					{
						Yf1 = Sb1Sr1;
						if (Sb1Sr1 <= Sb1Sr5) { Yf1 = Sb1Sr1; }
						else { Yf1 = Sb1Sr5; }
					}
					else { Yf1 = Sb1Sr4; }
				}
				else { Yf1 = Sb1Sr3; }
			}
			else
			{
				Yf1 = Sb1Sr2;
				if (Sb1Sr2 <= Sb1Sr3)
				{
					Yf1 = Sb1Sr2;
					if (Sb1Sr2 <= Sb1Sr4)
					{
						Yf1 = Sb1Sr2;
						if (Sb1Sr2 <= Sb1Sr5) { Yf1 = Sb1Sr2; }
						else { Yf1 = Sb1Sr5; }
					}
					else { Yf1 = Sb1Sr4; }
				}
				else
				{
					Yf1 = Sb1Sr3;
					if (Sb1Sr3 <= Sb1Sr4)
					{
						Yf1 = Sb1Sr3;
						if (Sb1Sr3 <= Sb1Sr5) { Yf1 = Sb1Sr3; }
						else { Yf1 = Sb1Sr5; }
					}
					else { Yf1 = Sb1Sr4; if (Sb1Sr4 <= Sb1Sr5) { Yf1 = Sb1Sr4; } else { Yf1 = Sb1Sr5; } }
				}
			}


			//2 стлб
			float Sb2Sr1 = float.Parse(TwoSbOneSr, System.Globalization.CultureInfo.InvariantCulture);
			float Sb2Sr2 = float.Parse(TwoSbTwoSr, System.Globalization.CultureInfo.InvariantCulture);
			float Sb2Sr3 = float.Parse(TwoSbThreeSr, System.Globalization.CultureInfo.InvariantCulture);
			float Sb2Sr4 = float.Parse(TwoSbFourSr, System.Globalization.CultureInfo.InvariantCulture);
			float Sb2Sr5 = float.Parse(TwoSbFiveSr, System.Globalization.CultureInfo.InvariantCulture);
			if (Sb2Sr1 <= Sb2Sr2)
			{
				Yf2 = Sb2Sr1;
				if (Sb2Sr1 <= Sb2Sr3)
				{
					Yf2 = Sb2Sr1;
					if (Sb2Sr1 <= Sb2Sr4)
					{
						Yf2 = Sb2Sr1;
						if (Sb2Sr1 <= Sb2Sr5) { Yf2 = Sb2Sr1; }
						else { Yf2 = Sb2Sr5; }
					}
					else { Yf2 = Sb2Sr4; }
				}
				else { Yf2 = Sb2Sr3; }
			}
			else
			{
				Yf2 = Sb2Sr2;
				if (Sb2Sr2 <= Sb2Sr3)
				{
					Yf2 = Sb2Sr2;
					if (Sb2Sr2 <= Sb2Sr4)
					{
						Yf2 = Sb2Sr2;
						if (Sb2Sr2 <= Sb2Sr5) { Yf2 = Sb2Sr2; }
						else { Yf2 = Sb2Sr5; }
					}
					else { Yf2 = Sb2Sr4; }
				}
				else
				{
					Yf2 = Sb2Sr3;
					if (Sb2Sr3 <= Sb2Sr4)
					{
						Yf2 = Sb2Sr3;
						if (Sb2Sr3 <= Sb2Sr5) { Yf2 = Sb2Sr3; }
						else { Yf2 = Sb2Sr5; }
					}
					else { Yf2 = Sb2Sr4; if (Sb2Sr4 <= Sb2Sr5) { Yf2 = Sb2Sr4; } else { Yf2 = Sb2Sr5; } }
				}
			}

			//3 стлб
			float Sb3Sr1 = float.Parse(ThreeSbOneSr, System.Globalization.CultureInfo.InvariantCulture);
			float Sb3Sr2 = float.Parse(ThreeSbTwoSr, System.Globalization.CultureInfo.InvariantCulture);
			float Sb3Sr3 = float.Parse(ThreeSbThreeSr, System.Globalization.CultureInfo.InvariantCulture);
			float Sb3Sr4 = float.Parse(ThreeSbFourSr, System.Globalization.CultureInfo.InvariantCulture);
			float Sb3Sr5 = float.Parse(ThreeSbFiveSr, System.Globalization.CultureInfo.InvariantCulture);
			if (Sb3Sr1 <= Sb3Sr2)
			{
				Yf3 = Sb3Sr1;
				if (Sb3Sr1 <= Sb3Sr3)
				{
					Yf3 = Sb3Sr1;
					if (Sb3Sr1 <= Sb3Sr4)
					{
						Yf3 = Sb3Sr1;
						if (Sb3Sr1 <= Sb3Sr5) { Yf3 = Sb3Sr1; }
						else { Yf3 = Sb3Sr5; }
					}
					else { Yf3 = Sb3Sr4; }
				}
				else { Yf3 = Sb3Sr3; }
			}
			else
			{
				Yf3 = Sb3Sr2;
				if (Sb3Sr2 <= Sb3Sr3)
				{
					Yf3 = Sb3Sr2;
					if (Sb3Sr2 <= Sb3Sr4)
					{
						Yf3 = Sb3Sr2;
						if (Sb3Sr2 <= Sb3Sr5) { Yf3 = Sb3Sr2; }
						else { Yf3 = Sb3Sr5; }
					}
					else { Yf3 = Sb3Sr4; }
				}
				else
				{
					Yf3 = Sb3Sr3;
					if (Sb3Sr3 <= Sb3Sr4)
					{
						Yf3 = Sb3Sr3;
						if (Sb3Sr3 <= Sb3Sr5) { Yf3 = Sb3Sr3; }
						else { Yf3 = Sb3Sr5; }
					}
					else { Yf3 = Sb3Sr4; if (Sb3Sr4 <= Sb3Sr5) { Yf3 = Sb3Sr4; } else { Yf3 = Sb3Sr5; } }
				}
			}

			//4 стлб
			float Sb4Sr1 = float.Parse(FourSbOneSr, System.Globalization.CultureInfo.InvariantCulture);
			float Sb4Sr2 = float.Parse(FourSbTwoSr, System.Globalization.CultureInfo.InvariantCulture);
			float Sb4Sr3 = float.Parse(FourSbThreeSr, System.Globalization.CultureInfo.InvariantCulture);
			float Sb4Sr4 = float.Parse(FourSbFourSr, System.Globalization.CultureInfo.InvariantCulture);
			float Sb4Sr5 = float.Parse(FourSbFiveSr, System.Globalization.CultureInfo.InvariantCulture);
			if (Sb4Sr1 <= Sb4Sr2)
			{
				Yf4 = Sb4Sr1;
				if (Sb4Sr1 <= Sb4Sr3)
				{
					Yf4 = Sb4Sr1;
					if (Sb4Sr1 <= Sb4Sr4)
					{
						Yf4 = Sb4Sr1;
						if (Sb4Sr1 <= Sb4Sr5) { Yf4 = Sb4Sr1; }
						else { Yf4 = Sb4Sr5; }
					}
					else { Yf4 = Sb4Sr4; }
				}
				else { Yf4 = Sb4Sr3; }
			}
			else
			{
				Yf4 = Sb4Sr2;
				if (Sb4Sr2 <= Sb4Sr3)
				{
					Yf4 = Sb4Sr2;
					if (Sb4Sr2 <= Sb4Sr4)
					{
						Yf4 = Sb4Sr2;
						if (Sb4Sr2 <= Sb4Sr5) { Yf4 = Sb4Sr2; }
						else { Yf4 = Sb4Sr5; }
					}
					else { Yf4 = Sb4Sr4; }
				}
				else
				{
					Yf4 = Sb4Sr3;
					if (Sb4Sr3 <= Sb4Sr4)
					{
						Yf4 = Sb4Sr3;
						if (Sb4Sr3 <= Sb4Sr5) { Yf4 = Sb4Sr3; }
						else { Yf4 = Sb4Sr5; }
					}
					else { Yf4 = Sb4Sr4; if (Sb4Sr4 <= Sb4Sr5) { Yf4 = Sb4Sr4; } else { Yf4 = Sb4Sr5; } }
				}
			}

			//5 стлб
			float Sb5Sr1 = float.Parse(FiveSbOneSr, System.Globalization.CultureInfo.InvariantCulture);
			float Sb5Sr2 = float.Parse(FiveSbTwoSr, System.Globalization.CultureInfo.InvariantCulture);
			float Sb5Sr3 = float.Parse(FiveSbThreeSr, System.Globalization.CultureInfo.InvariantCulture);
			float Sb5Sr4 = float.Parse(FiveSbFourSr, System.Globalization.CultureInfo.InvariantCulture);
			float Sb5Sr5 = float.Parse(FiveSbFiveSr, System.Globalization.CultureInfo.InvariantCulture);
			if (Sb5Sr1 <= Sb5Sr2)
			{
				Yf5 = Sb5Sr1;
				if (Sb5Sr1 <= Sb5Sr3)
				{
					Yf5 = Sb5Sr1;
					if (Sb5Sr1 <= Sb5Sr4)
					{
						Yf5 = Sb5Sr1;
						if (Sb5Sr1 <= Sb5Sr5) { Yf5 = Sb5Sr1; }
						else { Yf5 = Sb5Sr5; }
					}
					else { Yf5 = Sb5Sr4; }
				}
				else { Yf5 = Sb5Sr3; }
			}
			else
			{
				Yf5 = Sb5Sr2;
				if (Sb5Sr2 <= Sb5Sr3)
				{
					Yf5 = Sb5Sr2;
					if (Sb5Sr2 <= Sb5Sr4)
					{
						Yf5 = Sb5Sr2;
						if (Sb5Sr2 <= Sb5Sr5) { Yf5 = Sb5Sr2; }
						else { Yf5 = Sb5Sr5; }
					}
					else { Yf5 = Sb5Sr4; }
				}
				else
				{
					Yf5 = Sb5Sr3;
					if (Sb5Sr3 <= Sb5Sr4)
					{
						Yf5 = Sb5Sr3;
						if (Sb5Sr3 <= Sb5Sr5) { Yf5 = Sb5Sr3; }
						else { Yf5 = Sb5Sr5; }
					}
					else { Yf5 = Sb5Sr4; if (Sb5Sr4 <= Sb5Sr5) { Yf5 = Sb5Sr4; } else { Yf5 = Sb5Sr5; } }
				}
			}


			t = Yf1;
			t += Yf2;
			t += Yf3;
			t += Yf4;
			t += Yf5;
			@ViewBag.Sr = t / 5;
			return View();
		}







	}
}