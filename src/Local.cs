﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace gInk
{
	public class Local
	{
		Dictionary<string, string> Languages = new Dictionary<string, string>();

		public string CurrentLanguageFile;

		public string[] ButtonNamePen = new string[10];

		public string ButtonNamePenwidth = "Pen width";
		public string ButtonNameErasor = "Eraser";
		public string ButtonNamePan = "move one drawing | Pan all drawings";
		public string ButtonNameMousePointer = "Mouse pointer";
		public string ButtonNameInkVisible = "Ink visible";
		public string ButtonNameSnapshot = "Snapshot";
		public string ButtonNameUndo = "Undo";
		public string ButtonNameRedo = "Redo";
		public string ButtonNameClear = "Clear";
		public string ButtonNameExit = "Exit drawing";
		public string ButtonNameDock = "Dock/Undock";
        public string ButtonNameClose = "Close\n(in addition to Alt+F4)";
        public string ButtonNameHand = "Handfree drawing (standard | color filled | White filled | Black filled)";
        public string ButtonNameLine = "Line Shape";
        public string ButtonNameRect = "Rectangle shape (empty | color filled | White filled | Black filled)";
        public string ButtonNameOval = "Ellipsis shape (empty | color filled | White filled | Black filled)";
        public string ButtonNameArrow = "Arrow shape (head at start | at end)";
        public string ButtonNameNumb = "Numbered chip (put | reset number)";
        public string ButtonNameText = "Text (Left|Right aligned)";
        public string ButtonNameEdit = "Edit Text|chip";
        public string ButtonNameMagn = "Magnetic Effect";
        public string ButtonNameVideo = "Video Record";

        public string BoardTitle = "Clean Desktop";
        public string BoardText = "Erase all drawings and fill it with...";
        public string BoardTransparent = "Transparent";
        public string BoardWhite= "White";
        public string BoardGray= "Customed ";
        public string BoardBlack = "Black";
        public string BoardLast = "Last selected";

        public string OptionsGeneralBoardBox = "Background Board";
        public string BoardCustColorModifyTitle="Board Customed color";
        public string OptionsGeneralBoardAtOpenLbl="Background at toolbar opening";
        public string OptionsGeneralBoardCustColorLbl="Customed Background color";


        public string ButtonOkText = "&OK";
        public string ButtonCancelText = "&Cancel";
        public string ButtonFontText = "&Font";
        public string DlgTextCaption = "Edit Text";
        public string DlgTextLabel = "Text Input";
        public string DlgTagCaption = "Tag Numbering";
        public string DlgTagLabel = "Enter Starting Number";

        public string FormClipartsTitle = "ClipArts";
        public string ButtonInsertText = "&Insert";
        public string ButtonFromClipBText = "&From Clipboard";
        public string ButtonLoadImageText = "&Load Image";
        public string ButtonDeleteText = "&Delete entry";
        public string ListFillingsText = "No Frame;Empty;Color filled;White filled;Black filled";


        public string MenuEntryExit = "Exit";
		public string MenuEntryOptions = "Options";
		public string MenuEntryAbout = "About";

		public string OptionsTabGeneral = "General";
		public string OptionsTabPens = "Pens";
		public string OptionsTabHotkeys = "Hotkeys";

		public string OptionsGeneralLanguage = "Language";
        public string OptionsGeneralToolBarColorText = "Click on toolbar to select background color";
        public string OptionsGeneralAltTabActivateText = "Engage Pointer and Auto-Fold with Alt+Tab";
        public string OptionsGeneralToolbarHeight = "height(%scr)\n\n\nchanges after closing toolbar";

        public string OptionsGeneralCanvascursor = "Canvus cursor";
		public string OptionsGeneralCanvascursorArrow = "Arrow";
		public string OptionsGeneralCanvascursorPentip = "Pen tip";
		public string OptionsGeneralSnapshotsavepath = "Snapshot save path";
        public string OptionsGeneralOpenIntoSnapMode = "Start Snapshot Capture immediately after Opening Toolbar";
        public string OptionsGeneralWhitetrayicon = "Use white tray icon";
		public string OptionsGeneralAllowdragging = "Allow dragging toolbar";
        public string OptionsGeneralShowFloatingWindow = "Show Floating Window (at next restart)";
        public string OptionsGeneralSaveFloatingWindowPos = "Save Floating &window Pos";
        public string OptionsGeneralArrowHead = "ArrowHead";
        public string OptionsGeneralArrowHeadApt = "Aperture(°)";
        public string OptionsGeneralArrowHeadLen = "Length(%Scr)";
        public string OptionsGeneralDefaultTextLbl = "Default Text";
        public string OptionsGeneralDefaultTextBtn = "Select &Font && Size";
        public string OptionsGeneralDefaultArrHdBtn = "Default Arrow Head At Start";
        public string OptionsGeneralMagnetLbl = "Magnetic radius(%Scr) (<=0 = disabled)";
        public string OptionsGeneralSaveConfigToFile = "Save to Files";
        public string OptionsGeneralNotePenwidth = "Notes: (1)pen width panel overides each individual pen width settings\n  (2) Transparency and size of floating window to be modified directly in config.ini";

		public string OptionsPensShow = "Show";
		public string OptionsPensColor = "Color";
		public string OptionsPensAlpha = "Alpha";
		public string OptionsPensWidth = "Width";
		public string OptionsPensPencil = "Pencil";
		public string OptionsPensHighlighter = "Highlighter";
        public string OptionsPensWidthAtSelection = "Apply Width on Pen Selection\n(even with width selector)";

        public string OptionsPensThin = "Thin";
		public string OptionsPensNormal = "Normal";
		public string OptionsPensThick = "Thick";

        public string OptionsHotKeyAltAsOneCommand = "Process Alt as Temporary Command (Alt will be ignored in hotkeys)";
        public string OptionsHotkeysglobal = "Global hotkey (start drawing, switch between mouse pointer and drawing)";
		public string OptionsHotkeysEnableinpointer = "Enable all following hotkeys in mouse pointer mode (may cause a mess)";

        public string VideoTab="Video";
        public string OptNoVideo="No video recording";
        public string OptObsRecord="OBS recording";
        public string OptObsBcast="OBS broadcasting";
        public string LblWsUrl="WebSocket URL";
        public string LblWsPwd="Password";
        public string LblObsNote = "Note : OBS should be started before starting record\nOBS should be installed with Websocket plugin,with port and password configured";
        public string OptFfmpeg="FFmpeg recording";
        public string LblFfmpegCmd="Command Line";
        public string LblFfmpegNote = "Note :substitution in command line\n" +
                                      "            $xx$ $yy$                                             : upper left corner\n" +
                                      "            $ww$ $hh$                                             : width and height of capture\n" +
                                      "            $DD$ $MM$ $YY$ $YYYY$               : date\n"+
                                      "            $H$ $M$ $S$                                      : time\n"+
                                      "            %DD% %MM% %YY% %YYYY%     : date at ppInk startup\n"+
                                      "            %H% %M% %S%                               : time at ppInk startup\n"+
                                      "            $nn$                                                      : counter(restarted at 1 at ppInk restart)\n"+
                                      "            %VAR%                                                : use of environment variable VAR";
		public string NotificationSnapshot = "Snapshot saved. Click here to browse snapshots.";

        public Local()
		{
			ButtonNamePen[0] = "Pen 0";
			ButtonNamePen[1] = "Pen 1";
			ButtonNamePen[2] = "Pen 2";
			ButtonNamePen[3] = "Pen 3";
			ButtonNamePen[4] = "Pen 4";
			ButtonNamePen[5] = "Pen 5";
			ButtonNamePen[6] = "Pen 6";
			ButtonNamePen[7] = "Pen 7";
			ButtonNamePen[8] = "Pen 8";
			ButtonNamePen[9] = "Pen 9";

			LoadLocalList();
		}

		public void LoadLocalList()
		{
			DirectoryInfo d = new DirectoryInfo("./lang/");
			if (!d.Exists)
				d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "lang");
			if (!d.Exists)
				return;

			FileInfo[] Files = d.GetFiles("*.txt");
			foreach (FileInfo file in Files)
			{
				FileStream fini = new FileStream(file.FullName, FileMode.Open);
				StreamReader srini = new StreamReader(fini);
				string sLine;
				do
				{
					sLine = srini.ReadLine();
				}
				while (sLine != null && !sLine.StartsWith("LanguageName"));
				if (sLine == null)
					continue;
				string sPara = sLine.Substring(sLine.IndexOf("=") + 1);
				sPara = sPara.Trim();
				sPara = sPara.Trim('\"');
				string languagename = sPara;

				Languages.Add(file.Name.Substring(0, file.Name.Length - 4), sPara);

				fini.Close();
			}
		}

		public List<string> GetLanguagenames()
		{
			List<string> names = new List<string>();
			foreach (KeyValuePair<string, string> pair in Languages)
				names.Add(pair.Value);

			return names;
		}

		public string GetFilenameByLanguagename(string languagename)
		{
			foreach (KeyValuePair<string, string> pair in Languages)
				if (pair.Value == languagename)
					return pair.Key;

			return "";
		}

		public string GetLanguagenameByFilename(string filename)
		{
			foreach (KeyValuePair<string, string> pair in Languages)
				if (pair.Key == filename)
					return pair.Value;

			return "";
		}

		public void LoadLocalFile(string loname)
		{
			string filename = "./lang/" + loname + ".txt";

			if (!File.Exists(filename))
				filename = AppDomain.CurrentDomain.BaseDirectory + "lang/" + loname + ".txt";
			if (!File.Exists(filename))
				return;

			FileStream fini = new FileStream(filename, FileMode.Open);
			StreamReader srini = new StreamReader(fini);
			string sLine = "";
			string sName = "", sPara = "";
			while (sLine != null)
			{
				sLine = srini.ReadLine();
				if
				(
					sLine != null &&
					sLine != "" &&
					sLine.Substring(0, 1) != "-" &&
					sLine.Substring(0, 1) != "%" &&
					sLine.Substring(0, 1) != "'" &&
					sLine.Substring(0, 1) != "/" &&
					sLine.Substring(0, 1) != "!" &&
					sLine.Substring(0, 1) != "[" &&
					sLine.Substring(0, 1) != "#" &&
                    sLine.Contains("=")
                    //sLine.Contains("=") &&
                    //!sLine.Substring(sLine.IndexOf("=") + 1).Contains("=")
                )
				{
					sName = sLine.Substring(0, sLine.IndexOf("="));
					sName = sName.Trim();
					sPara = sLine.Substring(sLine.IndexOf("=") + 1).Replace("\\n","\n");
					sPara = sPara.Trim();
					sPara = sPara.Trim('\"');

					if (sName.StartsWith("ButtonNamePen"))
					{
						int penid = 0;
						if (int.TryParse(sName.Substring(13, 1), out penid))
						{
							ButtonNamePen[penid] = sPara;
						}
					}

					System.Reflection.FieldInfo fi = typeof(Local).GetField(sName);
					if (fi != null)
						fi.SetValue(this, sPara);
				}
			}
			fini.Close();

			CurrentLanguageFile = loname;
		}
	}
}
