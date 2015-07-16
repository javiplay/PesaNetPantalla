using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SolucionPesaNetPantalla
{
    public partial class TecladoNumerico : UserControl
    {
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public event ButtonClickedEventHandler OnUserControlButtonClicked;
        public TecladoNumerico()
        {
            InitializeComponent();
        }
        #region ButtonClick
        /// <summary>
        /// Touch pad button which will respond to the selected operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClick(object sender, EventArgs e)
        {
            Button btnNumber = sender as Button;

            OnUserControlButtonClicked(btnNumber, e);
            //switch (btnNumber.Text)
            //{
            //    case "0":
            //        OnUserControlButtonClicked(btnNumber, e);

            //        break;
            //    case "1":
            //        OnUserControlButtonClicked(btnNumber, e);

            //        break;
            //    case "2":
            //        OnUserControlButtonClicked(btnNumber, e);

            //        break;
            //    case "3":
            //        OnUserControlButtonClicked(btnNumber, e);

            //        break;
            //    case "4":
            //        OnUserControlButtonClicked(btnNumber, e);

            //        break;
            //    case "5":
            //        OnUserControlButtonClicked(btnNumber, e);

            //        break;
            //    case "6":
            //        OnUserControlButtonClicked(btnNumber, e);
            //        break;
            //    case "7":
            //        OnUserControlButtonClicked(btnNumber, e);

            //        break;
            //    case "8":
            //        OnUserControlButtonClicked(btnNumber, e);

            //        break;
            //    case "9":
            //        OnUserControlButtonClicked(btnNumber, e);

            //        break;
            //    case ".":
            //        OnUserControlButtonClicked(btnNumber, e);

            //        break;
            //    case "Back":
            //        OnUserControlButtonClicked(btnNumber, e);

            //        break;
            //}
        }
        #endregion
    }
}
