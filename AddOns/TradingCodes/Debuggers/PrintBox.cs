//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// 	Addon			:	PrintBox ("Better Chart Debugger")															//
//	Description		:	Helps debugging the indicators and strategies												//
//	Author			:	Trading.Codes (support@trading.codes), by T.Todua											//
//	URL				:	https://trading.codes/scripts/ninjatrader/chart-debugger-window-printbox/					//
//	Version			:   2019.03.28																					//
//	License			: 	CopyRight @ Maintain this head. Free for personal use.										//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Serialization;
using NinjaTrader.Cbi;
using NinjaTrader.Gui;
using NinjaTrader.Gui.Chart;
using NinjaTrader.Gui.SuperDom;
using NinjaTrader.Gui.Tools;
using NinjaTrader.Data;
using NinjaTrader.NinjaScript;
using NinjaTrader.Core.FloatingPoint;
using NinjaTrader.Gui.Tools;
using System.Windows.Forms;
using System.IO;



#region Extend the Strategy & Indicator classes
namespace NinjaTrader.NinjaScript.Strategies
{
    public partial class Strategy //: NinjaTrader.Gui.NinjaScript.StrategyRenderBase
    {
        protected TradingCodes.Debugger.PrintBox DP_;

        public virtual void PrintBox(object a1)
        {
            if (DP_ == null && ChartControl != null)
            {
				DP_ = new TradingCodes.Debugger.PrintBox();
				DP_.init_or_deinit(this, true);
            }
            DP_.PRINT(a1);
        }

        // Overloads //
        public virtual void PrintBox(object a1, object a2)
        { PrintBox((a1==null ? "null" : a1.ToString()) + " | " + (a2==null ? "null" : a2.ToString())); }
        public virtual void PrintBox(object a1, object a2, object a3)
        { PrintBox((a1==null ? "null" : a1.ToString()) + " | " + (a2==null ? "null" : a2.ToString()) + " | " + (a3==null ? "null" : a3.ToString())); }
        public virtual void PrintBox(object a1, object a2, object a3, object a4)
        { PrintBox((a1==null ? "null" : a1.ToString()) + " | " + (a2==null ? "null" : a2.ToString()) + " | " + (a3==null ? "null" : a3.ToString()) + " | " + (a4==null ? "null" : a4.ToString())); }
        public virtual void PrintBox(object a1, object a2, object a3, object a4, object a5)
        { PrintBox((a1==null ? "null" : a1.ToString()) + " | " + (a2==null ? "null" : a2.ToString()) + " | " + (a3==null ? "null" : a3.ToString()) + " | " + (a4==null ? "null" : a4.ToString()) + " | " + (a5==null ? "null" : a5.ToString())); }
        public virtual void PrintBox(object a1, object a2, object a3, object a4, object a5, object a6)
        { PrintBox((a1==null ? "null" : a1.ToString()) + " | " + (a2==null ? "null" : a2.ToString()) + " | " + (a3==null ? "null" : a3.ToString()) + " | " + (a4==null ? "null" : a4.ToString()) + " | " + (a5==null ? "null" : a5.ToString()) + " | " + (a6==null ? "null" : a6.ToString())); }
        public virtual void PrintBox(object a1, object a2, object a3, object a4, object a5, object a6, object a7)
        { PrintBox((a1==null ? "null" : a1.ToString()) + " | " + (a2==null ? "null" : a2.ToString()) + " | " + (a3==null ? "null" : a3.ToString()) + " | " + (a4==null ? "null" : a4.ToString()) + " | " + (a5==null ? "null" : a5.ToString()) + " | " + (a6==null ? "null" : a6.ToString())+ " | " + (a7==null ? "null" : a7.ToString())); }
        public virtual void PrintBox(object a1, object a2, object a3, object a4, object a5, object a6, object a7, object a8)
        { PrintBox((a1==null ? "null" : a1.ToString()) + " | " + (a2==null ? "null" : a2.ToString()) + " | " + (a3==null ? "null" : a3.ToString()) + " | " + (a4==null ? "null" : a4.ToString()) + " | " + (a5==null ? "null" : a5.ToString()) + " | " + (a6==null ? "null" : a6.ToString())+ " | " + (a7==null ? "null" : a7.ToString())+ " | " + (a8==null ? "null" : a8.ToString())); }

        // ShortHands //
        public virtual void P(object a1) { PrintBox(a1); }
        public virtual void P(object a1, object a2) { PrintBox(a1, a2); }
        public virtual void P(object a1, object a2, object a3) { PrintBox(a1, a2, a3); }
        public virtual void P(object a1, object a2, object a3, object a4) { PrintBox(a1, a2, a3, a4); }
        public virtual void P(object a1, object a2, object a3, object a4, object a5) { PrintBox(a1, a2, a3, a4, a5); }
        public virtual void P(object a1, object a2, object a3, object a4, object a5, object a6) { PrintBox(a1, a2, a3, a4, a5, a6); }
        public virtual void P(object a1, object a2, object a3, object a4, object a5, object a6, object a7) { PrintBox(a1, a2, a3, a4, a5, a6, a7); }
        public virtual void P(object a1, object a2, object a3, object a4, object a5, object a6, object a7, object a8) { PrintBox(a1, a2, a3, a4, a5, a6, a7, a8); }
    }
}


namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class Indicator //: NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
    {
        protected TradingCodes.Debugger.PrintBox DP_;

        public virtual void PrintBox(object a1)
        {
			if (DP_ == null && ChartControl != null)
            {
				DP_ = new TradingCodes.Debugger.PrintBox();
				DP_.init_or_deinit(this, true);
            }
            DP_.PRINT(a1);
        }

        // Overloads //
        public virtual void PrintBox(object a1, object a2)
        { PrintBox((a1==null ? "null" : a1.ToString()) + " | " + (a2==null ? "null" : a2.ToString())); }
        public virtual void PrintBox(object a1, object a2, object a3)
        { PrintBox((a1==null ? "null" : a1.ToString()) + " | " + (a2==null ? "null" : a2.ToString()) + " | " + (a3==null ? "null" : a3.ToString())); }
        public virtual void PrintBox(object a1, object a2, object a3, object a4)
        { PrintBox((a1==null ? "null" : a1.ToString()) + " | " + (a2==null ? "null" : a2.ToString()) + " | " + (a3==null ? "null" : a3.ToString()) + " | " + (a4==null ? "null" : a4.ToString())); }
        public virtual void PrintBox(object a1, object a2, object a3, object a4, object a5)
        { PrintBox((a1==null ? "null" : a1.ToString()) + " | " + (a2==null ? "null" : a2.ToString()) + " | " + (a3==null ? "null" : a3.ToString()) + " | " + (a4==null ? "null" : a4.ToString()) + " | " + (a5==null ? "null" : a5.ToString())); }
        public virtual void PrintBox(object a1, object a2, object a3, object a4, object a5, object a6)
        { PrintBox((a1==null ? "null" : a1.ToString()) + " | " + (a2==null ? "null" : a2.ToString()) + " | " + (a3==null ? "null" : a3.ToString()) + " | " + (a4==null ? "null" : a4.ToString()) + " | " + (a5==null ? "null" : a5.ToString()) + " | " + (a6==null ? "null" : a6.ToString())); }
        public virtual void PrintBox(object a1, object a2, object a3, object a4, object a5, object a6, object a7)
        { PrintBox((a1==null ? "null" : a1.ToString()) + " | " + (a2==null ? "null" : a2.ToString()) + " | " + (a3==null ? "null" : a3.ToString()) + " | " + (a4==null ? "null" : a4.ToString()) + " | " + (a5==null ? "null" : a5.ToString()) + " | " + (a6==null ? "null" : a6.ToString())+ " | " + (a7==null ? "null" : a7.ToString())); }
        public virtual void PrintBox(object a1, object a2, object a3, object a4, object a5, object a6, object a7, object a8)
        { PrintBox((a1==null ? "null" : a1.ToString()) + " | " + (a2==null ? "null" : a2.ToString()) + " | " + (a3==null ? "null" : a3.ToString()) + " | " + (a4==null ? "null" : a4.ToString()) + " | " + (a5==null ? "null" : a5.ToString()) + " | " + (a6==null ? "null" : a6.ToString())+ " | " + (a7==null ? "null" : a7.ToString())+ " | " + (a8==null ? "null" : a8.ToString())); }

        // ShortHands //
        public virtual void P(object a1) { PrintBox(a1); }
        public virtual void P(object a1, object a2) { PrintBox(a1, a2); }
        public virtual void P(object a1, object a2, object a3) { PrintBox(a1, a2, a3); }
        public virtual void P(object a1, object a2, object a3, object a4) { PrintBox(a1, a2, a3, a4); }
        public virtual void P(object a1, object a2, object a3, object a4, object a5) { PrintBox(a1, a2, a3, a4, a5); }
        public virtual void P(object a1, object a2, object a3, object a4, object a5, object a6) { PrintBox(a1, a2, a3, a4, a5, a6); }
        public virtual void P(object a1, object a2, object a3, object a4, object a5, object a6, object a7) { PrintBox(a1, a2, a3, a4, a5, a6, a7); }
        public virtual void P(object a1, object a2, object a3, object a4, object a5, object a6, object a7, object a8) { PrintBox(a1, a2, a3, a4, a5, a6, a7, a8); }
    }
}
#endregion

 






#region DEBUGGER class

namespace TradingCodes.Debugger
{ 
	//====debugger ====//
	// in OnStateChange():	d.init_or_deinit(this, true); 
	// OnBarUpdate:			d.PRINT(...);

	public class PrintBox
	{
		private string nl = Environment.NewLine;
		private string logFile= Environment.GetEnvironmentVariable("tmp") + "\\NT8_PrintBoxLog.txt";
		public bool debug_log_enabled = false;
		private void log(string txt){ if (debug_log_enabled) lock(logFile){ File.AppendAllText( logFile, nl + txt ); } }

		System.Windows.Forms.Form logForm;
		System.Windows.Forms.RichTextBox textarea;


		public NinjaTrader.NinjaScript.Strategies.Strategy strat;
		public NinjaTrader.NinjaScript.Indicators.Indicator indi;
		public NinjaTrader.NinjaScript.NinjaScriptBase indi_or_strat;
		ChartControl chartControl;
		ChartPanel chartPnl;
		ChartBars chartBars;
		bool enabled;

		public void init_or_deinit(object indi_or_strat_, bool init)
		{
			log("init_or_deinit1");
			if (init && indi_or_strat==null)
			{
				// for generic purposes
				indi_or_strat = (NinjaTrader.NinjaScript.NinjaScriptBase)indi_or_strat_;

				if (indi_or_strat_ is NinjaTrader.NinjaScript.Indicators.Indicator) {
					indi= (NinjaTrader.NinjaScript.Indicators.Indicator) indi_or_strat_;
					chartControl= indi.ChartControl;
					chartPnl	= indi.ChartControl.ChartPanels[0];
					chartBars	= indi.ChartBars;
				} 
				else if (indi_or_strat_ is NinjaTrader.NinjaScript.Strategies.Strategy)
				{
					strat =(NinjaTrader.NinjaScript.Strategies.Strategy) indi_or_strat_;
					chartControl= strat.ChartControl;
					chartPnl	= strat.ChartControl.ChartPanels[0]; 
					chartBars	= strat.ChartBars;
				}

				if (chartControl == null || chartPnl == null) { 
					enabled=false; return;
				}

				enabled = true;
				registerEventHandlers();
			}
			else
			{
				checkForDeregister();
			}
			log("init_or_deinit2");
		}
			
		
		//
		public void registerEventHandlers()
		{ 
			log("registerEventHandlers1");
			try
			{
				chartControl.Dispatcher.InvokeAsync(() =>
				{
					chartPnl.MouseDown += this.OnMouseDownEvent ;//new MouseButtonEventHandler(midasMouseEvents);
					chartPnl.KeyDown += this.onKeyDown; 
					createForm();
				}); 
			}
			catch(Exception e){ }
			log("registerEventHandlers2");
		}
		public void deRegisterEventHandlers()
		{
			log("deRegisterEventHandlers1");
			chartPnl.MouseDown -= this.OnMouseDownEvent;
			chartPnl.KeyDown -= this.onKeyDown;
			if (logForm != null) 
				logForm.Resize -= resizeTextarea; 
			destroyForm(true); 
			log("deRegisterEventHandlers2");
		}
			 
		public bool checkForDeregister()
		{
			log("checkForDeregister1");
			if (enabled ) 
			{
				if (indi_or_strat == null || (indi_or_strat.State != null &&  indi_or_strat.State== State.Finalized) )
				{
					if (chartPnl!=null)
					{
						deRegisterEventHandlers(); 
						enabled=false;
						return true;
					}
				}
			}
			log("checkForDeregister2");
			return false;
		}
			
		private string temp_w = Environment.GetEnvironmentVariable("tmp") + "\\__temp_form_opts_WIDTH";
		private string temp_h = Environment.GetEnvironmentVariable("tmp") + "\\__temp_form_opts_HEIGHT";

		public Dictionary<string, string> headerDict = new Dictionary<string,string>();
		public Dictionary<string, string> primaryDict = new Dictionary<string,string>();
		public Dictionary<string, string> secondaryDict = new Dictionary<string,string>();

		public class myForm : Form
		{
			protected override bool ShowWithoutActivation
			{
				get { return true; }
			}
		}
		public void createForm()
		{
			log("createForm1"); 
			//logForm = new Form( indi_or_strat.Owner );
			logForm = new myForm();
			logForm.Width = Math.Max(100,   (File.Exists(temp_w) ? Convert.ToInt32(File.ReadAllText(temp_w)) : 610) );
			logForm.Height = Math.Max(100,   (File.Exists(temp_h) ? Convert.ToInt32(File.ReadAllText(temp_h)) : 450) );
			logForm.Resize += resizeTextarea; 
			logForm.Text = @"PrintBox";
			logForm.TopMost = true; 
			logForm.StartPosition = FormStartPosition.Manual;
			// set position to most left top
			logForm.Top = 1; logForm.Left = 1;
			logForm.Opacity = 0.85; 
			//
			textarea= new System.Windows.Forms.RichTextBox(); 
			logForm.Controls.Add( textarea);
			textarea.Multiline = true;
			textarea.ScrollBars = RichTextBoxScrollBars.Both;
			resizeTextarea(null,null);
			//textarea.Font = new SimpleFont(textarea.Font.FontFamily, 11); 
			log("createForm2");
		}
		public void destroyForm(bool dispose)
		{
			log("destroyForm1");
			if (logForm != null) {
				logForm.Close();
				if (dispose) logForm.Dispose();
				logForm = null; 
			}
			log("destroyForm2");
		}
			
			
		public void resizeTextarea(object sender, System.EventArgs e)
		{
			int scrollbar = 17;
			textarea.Width = textarea.Parent.Width-scrollbar;
			textarea.Height = textarea.Parent.Height-scrollbar*2;
			File.WriteAllText(temp_w, logForm.Width.ToString());
			File.WriteAllText(temp_h, logForm.Height.ToString());
		}
	 
			 
		DateTime lastPressTime = DateTime.MinValue; 
		bool isKeyPressed= false; bool firstShow;
			
		private void onKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			/*
			System.Windows.Forms.MessageBox.Show(e.Key.ToString());
			if (e.KeyboardDevice.IsKeyDown(Key.F5))
			{
				if (indi != null) ((NinjaTrader.Gui.NinjaScript.IndicatorRenderBase)indi).ForceRefresh();
				if (strat != null) ((NinjaTrader.Gui.NinjaScript.StrategyRenderBase)strat).ForceRefresh();
			}
			//isKeyPressed =false; if (e.KeyboardDevice.IsKeyDown(Key.LeftShift)) { isKeyPressed =true; lastPressTime=DateTime.Now; }
			*/
		}
		//private void onKeyUp(object sender, KeyEventArgs e) { isKeyPressed=false; Print("keyup");}
			
		private void OnMouseDownEvent(object sender, MouseButtonEventArgs e)
		{
			log("OnMouseDownEvent1");
			if (checkForDeregister()) return;
				
			if (indi_or_strat !=null )
			{
				log("OnMouseDownEvent1-A");
				Point cPos = chartControl.MouseDownPoint;
				// Coefficient between Bar and it's margin space is 0.65
				int posX = (int)ChartingExtensions.ConvertToHorizontalPixels(cPos.X+chartControl.BarWidthArray[0]*1.65, chartControl.PresentationSource);
				int slot = (int)chartControl.GetSlotIndexByX(posX);
				//IBar thebar = GetBarFromX(e.X);
					 
				//if clicked on visible
				if(slot >= chartBars.FromIndex && slot <= chartBars.ToIndex)
				{
					log("OnMouseDownEvent1-B");
					int clicked_Bar = slot;
					// If Shift + Click , then open form
					if (System.Windows.Forms.Control.ModifierKeys == Keys.Shift) //isKeyPressed
					{
						//isKeyPressed=false;
						if (logForm == null || logForm.IsDisposed)
						{
							createForm();
						}
						if(!logForm.Visible)
						{
							logForm.Show(); 
						}
					}
					log("OnMouseDownEvent1-C");

					// If By this moment, form is/was open, show values
					if (logForm !=null && logForm.Visible)
					{
						if (!firstShow) { firstShow = true; logForm.BringToFront(); }
						log("OnMouseDownEvent1-D"); 
						if (indi_or_strat.BarsArray[0] != null)
						{
							log("OnMouseDownEvent1-E");
							Bars bars = indi_or_strat.BarsArray[0];
							int barsAgo = indi_or_strat.CurrentBars[0]-clicked_Bar;
							if (clicked_Bar <= 0 ) 
								return;
							TradingCodes.Helpers.DrawVerticalLineBlinking(indi_or_strat, barsAgo);

							string bn_primary = TradingCodes.Helpers.barIdentifier( indi_or_strat, barsAgo );
							string bn_secondary = TradingCodes.Helpers.barIdentifier( indi_or_strat, barsAgo + (indi_or_strat.Calculate == Calculate.OnBarClose || indi_or_strat.State == State.Historical ? 1 : 0) );  //ticks are 1 bar earlier for OnBarClose
							string header	= (headerDict.ContainsKey(bn_primary)	? headerDict[bn_primary]		: "" );
							string primary	= (primaryDict.ContainsKey(bn_primary)	? primaryDict[bn_primary]		: "" );
							/*
							string bn_prev = clicked_Bar <= 0 ? "" :  TradingCodes.Helpers.barIdentifier( indi_or_strat, barsAgo+1 );
							string secondary=clicked_Bar <= 0 ? "" :  ( secondaryDict.ContainsKey(bn_prev) ? secondaryDict[ bn_prev ]	: "" );
							*/
							string warning_message = nl + "############ Warning ############" + nl + " Typically, additional (granular) BIP data (except the first one) is used to form the next Primary BAR."+ nl + "To understand DataSeries better, must read: - https://goo.gl/ScpDkN"+nl+"##############################"+nl;
							string secondary= ( secondaryDict.ContainsKey(bn_secondary) ? warning_message + secondaryDict[bn_secondary]	: "__" );
							//need spaces between special chars to avoid conversion
							textarea.Rtf = new StringBuilder().Append(@"{\rtf1\ansi " + header.Replace(nl, @"\par ") +" " + primary.Replace(nl, @"\par ") +" "+ secondary.Replace(nl, @"\par").Replace("_BOLDSTART_", @"\b").Replace("_BOLDEND_", @"\b0") + @" }").ToString();
							log("OnMouseDownEvent1-F");
						}
					}
				}
			}
			log("OnMouseDownEvent2");
		}

		//PRINT( (text1 == null ? "null" : (text1 is double ? (indi_or_strat.Instrument.MasterInstrument.RoundToTickSize((double)text1)).ToString("N6") : text1.ToString() )) + " : "+ (text2 == null ? "null" : (text2 is double ? (indi_or_strat.Instrument.MasterInstrument.RoundToTickSize((double)text2)).ToString("N6") : text2.ToString()))); 

		public void PRINT(object text1)
		{
			log("PRINT_start");
			if (!enabled) return;
			if (checkForDeregister()) return;
			if (indi_or_strat.CurrentBars[0] < 1 || indi_or_strat.CurrentBar < 1) return;
			string BN_current = TradingCodes.Helpers.barIdentifier(indi_or_strat, 0);
			string currText = (text1 == null ? "null" : (text1 is double ? (indi_or_strat.Instrument.MasterInstrument.RoundToTickSize((double)text1)).ToString("N6") : text1.ToString())) + nl;

			log("PRINT2");
			if (!headerDict.ContainsKey(BN_current))
			{                                                   //indi_or_strat.BarsArray[0].GetTime(barNumb)
				headerDict[BN_current] = "Bar CloseTime: " + ((indi_or_strat.Times[0][0]).ToString("HH:mm:ss.fff  dd/MMM/yyyy") + " [ BarN: " + indi_or_strat.CurrentBars[0] + ";    O:" + indi_or_strat.Opens[0][0] + "    H:" + indi_or_strat.Highs[0][0] + "    L:" + indi_or_strat.Lows[0][0] + "    C:" + indi_or_strat.Closes[0][0] + " ]" + nl + "----------------------------" + nl);
			}


			// 

			if (indi_or_strat.BarsInProgress == 0)
			{
				var chosenTime = timeNow;// timeNow lacks MS... DateTime.Now has
				if (indi_or_strat.State == State.Realtime) currText = "[" + chosenTime.ToString("HH:mm:ss") + "; ^" + DateTime.Now.Millisecond +"]  " + currText;
				primaryDict[BN_current] = (primaryDict.ContainsKey(BN_current) ? primaryDict[BN_current] : "") + currText;
			}
			else
			{
				// If this is exected on 2nd timeframe (i.e. from BarsInProgress =1 ), then we should write that for prev.bar, as the bars timestamps are on endings: https://trading.codes/tutorials/ninjatrader-multi-timeframe-realtime-historical-difference/
				secondaryDict[BN_current] = (secondaryDict.ContainsKey(BN_current) ? secondaryDict[BN_current] : "") + "• [BIP:" + indi_or_strat.BarsInProgress + "; " + indi_or_strat.Time[0].ToString("ddMMM/HH:mm:ss.fff ") + " ^BN: ("+indi_or_strat.CurrentBars[0] + ") " + indi_or_strat.CurrentBar + " ] >>> _BOLDSTART_ " + currText + " _BOLDEND_ ";
			}
			log("PRINT_end");
		}

		DateTime timeNow { get { return (NinjaTrader.Cbi.Connection.PlaybackConnection != null ? NinjaTrader.Cbi.Connection.PlaybackConnection.Now : NinjaTrader.Core.Globals.Now); } }
	} 
}
	
#endregion








#region helpers
namespace TradingCodes 
{
	public partial class Helpers  
	{
		public static string barIdentifier( object NinjaScript_, int barsAgo){
			NinjaTrader.NinjaScript.NinjaScriptBase obj = (NinjaTrader.NinjaScript.NinjaScriptBase) NinjaScript_;
			if (obj.CurrentBars[0] <1) return "";
			return sanitize_filename( getNinjaScriptIdentifier(obj, true) + "--" + obj.BarsArray[0].GetTime(obj.CurrentBars[0]-barsAgo).ToString("yyyy-MM-dd_HH-mm-ss") , "");
		} 
		
		public static string getNinjaScriptIdentifier( object NinjaScript_ , bool include_script_name){
			NinjaTrader.NinjaScript.NinjaScriptBase obj = (NinjaTrader.NinjaScript.NinjaScriptBase) NinjaScript_;
			return sanitize_filename((include_script_name ? obj.Name + "_" : "" ) + obj.Instrument.FullName + "--" + obj.BarsArray[0].BarsPeriod.BarsPeriodType.ToString() +"-"+obj.BarsArray[0].BarsPeriod.Value.ToString(), "") ; 
		}
		
		public static int ChartInSeconds(NinjaTrader.NinjaScript.NinjaScriptBase NS_)
		{
			int final_val = 0;
			if 		( NS_.BarsPeriod.BarsPeriodType == BarsPeriodType.Second)	final_val = NS_.BarsPeriod.Value;
			else if ( NS_.BarsPeriod.BarsPeriodType == BarsPeriodType.Minute)	final_val = NS_.BarsPeriod.Value*60;
			else if ( NS_.BarsPeriod.BarsPeriodType == BarsPeriodType.Day) 		final_val = NS_.BarsPeriod.Value*60*60*24;
			else if ( NS_.BarsPeriod.BarsPeriodType == BarsPeriodType.Week) 	final_val = NS_.BarsPeriod.Value*60*60*24*7;
			else if ( NS_.BarsPeriod.BarsPeriodType == BarsPeriodType.Month) 	final_val = NS_.BarsPeriod.Value*60*60*24*7*30;
			else if ( NS_.BarsPeriod.BarsPeriodType == BarsPeriodType.Year) 	final_val = NS_.BarsPeriod.Value*60*60*24*7*365;
			return final_val;
		}
		
		private static int randLast; 
		public static void DrawVerticalLineBlinking(NinjaTrader.NinjaScript.NinjaScriptBase indi_or_strat, int idx)
		{
			try{
				int rand = new Random().Next(100000);
				RemoveDrawObject(indi_or_strat, "Debugger_CurrentBarVLine"+randLast);
				int clicked_Bar= indi_or_strat.CurrentBars[0]-idx  + (indi_or_strat.BarsPeriod.BarsPeriodType == BarsPeriodType.Day ? 1 : 0) ;  //don't know, on daily was displaced
				Bars bars = indi_or_strat.BarsArray[0];
				if (clicked_Bar+1 >= indi_or_strat.Bars.Count)
				{
					return; //I donno, I couldn't make it work on last bar, so just hide it
				}
				//NinjaTrader.NinjaScript.DrawingTools.Draw.VerticalLine(indi_or_strat, "Debugger_CurrentBarVLine"+rand, idx, Brushes.Orange, DashStyleHelper.DashDot, 2);
				var time = bars.GetTime(clicked_Bar);//.AddSeconds(-ChartInSeconds(indi_or_strat)/6);
				NinjaTrader.NinjaScript.DrawingTools.Draw.VerticalLine(indi_or_strat, "Debugger_CurrentBarVLine"+rand, time, Brushes.Orange, DashStyleHelper.DashDot, 2);
				
				// in 5 seconds, remove it
				System.Threading.Timer timer = null;
				timer = new System.Threading.Timer(
					(object state) => { 
						RemoveDrawObject(indi_or_strat, "Debugger_CurrentBarVLine"+rand);
						timer.Dispose();
					}
					, null // no state required
					,TimeSpan.FromSeconds(5) // Do it in x seconds
					,TimeSpan.FromMilliseconds(-1)
				); // don't repeat
				
				randLast = rand; 
			}
			catch(Exception ex)
			{
				indi_or_strat.Print(ex.ToString());
			}
		}
		
		
		
		public static void RemoveDrawObject(object xyz, string name)
		{
			try 
			{ 
				if		(xyz is NinjaTrader.Gui.NinjaScript.IndicatorRenderBase)
				{
					var IRB = (xyz as NinjaTrader.Gui.NinjaScript.IndicatorRenderBase);
					IRB.RemoveDrawObject(name);
				}
				else if (xyz is NinjaTrader.Gui.NinjaScript.StrategyRenderBase)
				{
					var IRB = (xyz as NinjaTrader.Gui.NinjaScript.StrategyRenderBase);
					IRB.RemoveDrawObject(name);
				}
			}
			catch{}
		}
 

		public static string sanitize_filename(string dirtyString, string sanitizeType)
		{
			string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
			foreach (char c in invalid)  dirtyString = dirtyString.Replace(c.ToString(), "");  
			return dirtyString;
		}
		
    }
}
#endregion