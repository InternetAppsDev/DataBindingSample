﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataBinding
{
    /*
     * for a class to be able to bind, need to implement the
     * INotifyPropertyChanged interface
     * register interest
     */
    public class myAdder : INotifyPropertyChanged
    {
        // implement the PropertyChanged event
        public event PropertyChangedEventHandler PropertyChanged;

        // == private variables ==
        private int arg1;
        private int arg2;

        // == properties ==
        public int Arg1
        {
            get { return arg1; }    // x = myAdder.Arg1
            set
            {
                arg1 = value;   // myAdder.Arg1 = x;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, 
                        new PropertyChangedEventArgs("AnswerValue"));
                    PropertyChanged(this,
                        new PropertyChangedEventArgs("Arg1"));
                }
            }
        }

        public int Arg2
        {
            get { return arg2; }
            set
            {
                arg2 = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this,
                        new PropertyChangedEventArgs("AnswerValue"));
                    PropertyChanged(this,
                        new PropertyChangedEventArgs("Arg2"));
                }
            }
        }
        
        public int AnswerValue
        {
            get
            {
                return arg1 + arg2;
            }
        }

    } // end of class myAdder
}
