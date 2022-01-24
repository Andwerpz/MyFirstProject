using MyFirstProject.Models;
using MyFirstProject.ViewViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ViewViewModels.Controls.Entry.EntryPractice.EntryResult
{
    public class EntryResultViewModel : BaseViewModel
    {
        private string _entryText = string.Empty;
        public EntryResultViewModel(string _entryText)
        {
            Title = Titles.EntryResultTitle;
            this._entryText = _entryText;
        }

        public string EntryText
        {
            get { return _entryText; }

            set
            {

                if (_entryText != value)
                {
                    SetProperty(ref _entryText, value);
                }

            }
        }
    }
}
