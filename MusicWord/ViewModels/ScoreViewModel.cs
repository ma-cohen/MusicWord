﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicWord.Models;
namespace MusicWord.ViewModels
{
    class ScoreViewModel: AppScreen
    {
		private int _score;
		public ScoreViewModel()
		{
			Score = PlayerModel.Instance.Score;
			HiddenWord = Globals.hiddenWordText + PlayerModel.Instance.lastWord;
		}
		public int  Score
		{
			get { return _score; }
			set 
			{ 
				_score = value;
				NotifyOfPropertyChange(() => Score);
			}
		}
		public void Next()
		{
			NextScreen();
		}

		public string HiddenWord { get; set; }

	}
}