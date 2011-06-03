﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JsParserCore.Properties;

namespace JsParserCore.UI
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Settings.Default.TrackActiveItem = chTrackActiveItem.Checked;
			Settings.Default.Extensions = new System.Collections.Specialized.StringCollection();
			Settings.Default.ShowHideAutomatically = chShowHideAutomatically.Checked;
			Settings.Default.Extensions.AddRange(edExtensions.Lines);

			Settings.Default.taggedFunction1Color = taggedFuncLabel1.ForeColor;
			Settings.Default.taggedFunction1Font = taggedFuncLabel1.Font;
			Settings.Default.taggedFunction2Color = taggedFuncLabel2.ForeColor;
			Settings.Default.taggedFunction2Font = taggedFuncLabel2.Font;
			Settings.Default.taggedFunction3Color = taggedFuncLabel3.ForeColor;
			Settings.Default.taggedFunction3Font = taggedFuncLabel3.Font;
			Settings.Default.taggedFunction4Color = taggedFuncLabel4.ForeColor;
			Settings.Default.taggedFunction4Font = taggedFuncLabel4.Font;
			Settings.Default.taggedFunction5Color = taggedFuncLabel5.ForeColor;
			Settings.Default.taggedFunction5Font = taggedFuncLabel5.Font;
			Settings.Default.taggedFunction6Color = taggedFuncLabel6.ForeColor;
			Settings.Default.taggedFunction6Font = taggedFuncLabel6.Font;

			Settings.Default.Save();
			Close();
		}

		private void SettingsForm_Load(object sender, EventArgs e)
		{
			chTrackActiveItem.Checked = Settings.Default.TrackActiveItem;
			edExtensions.Lines = Settings.Default.Extensions.OfType<string>().ToArray();
			chShowHideAutomatically.Checked = Settings.Default.ShowHideAutomatically;

			taggedFuncLabel1.ForeColor = Settings.Default.taggedFunction1Color;
			taggedFuncLabel1.Font = Settings.Default.taggedFunction1Font;
			taggedFuncLabel2.ForeColor = Settings.Default.taggedFunction2Color;
			taggedFuncLabel2.Font = Settings.Default.taggedFunction2Font;
			taggedFuncLabel3.ForeColor = Settings.Default.taggedFunction3Color;
			taggedFuncLabel3.Font = Settings.Default.taggedFunction3Font;
			taggedFuncLabel4.ForeColor = Settings.Default.taggedFunction4Color;
			taggedFuncLabel4.Font = Settings.Default.taggedFunction4Font;
			taggedFuncLabel5.ForeColor = Settings.Default.taggedFunction5Color;
			taggedFuncLabel5.Font = Settings.Default.taggedFunction5Font;
			taggedFuncLabel6.ForeColor = Settings.Default.taggedFunction6Color;
			taggedFuncLabel6.Font = Settings.Default.taggedFunction6Font;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			ShowFontDialogForLabel(taggedFuncLabel1);
		}

		private void ShowFontDialogForLabel(Label lbl)
		{
			fontDialog1.AllowScriptChange = false;
			fontDialog1.AllowVerticalFonts = false;
			fontDialog1.ShowColor = true;
			fontDialog1.ShowEffects = true;
			fontDialog1.FontMustExist = true;

			fontDialog1.Font = lbl.Font;
			fontDialog1.Color = lbl.ForeColor;

			if (fontDialog1.ShowDialog() == DialogResult.OK)
			{
				lbl.Font = fontDialog1.Font;
				lbl.ForeColor = fontDialog1.Color;
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			ShowFontDialogForLabel(taggedFuncLabel2);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			ShowFontDialogForLabel(taggedFuncLabel3);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			ShowFontDialogForLabel(taggedFuncLabel4);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			ShowFontDialogForLabel(taggedFuncLabel5);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			ShowFontDialogForLabel(taggedFuncLabel6);
		}
	}
}
