﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace PageProfile.Models
{
    internal class UserBookDaysModel:BaseViewModel
    {
        public ICommand ContinueBtnCmd { get; set; }
        public ICommand BackBtnCmd { get; set; }
    }
}
