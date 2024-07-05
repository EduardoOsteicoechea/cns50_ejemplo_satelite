﻿using ExampleSatelite.Sage50.AvantLeap.SalesBill;
using ExampleSatelite.Sage50.AvantLeap.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSatelite.Sage50.AvantLeap.PurchaseBill
{
    internal class CreatePurchaseBillForm : System.Windows.Forms.Form
    {
        public CreatePurchaseBillForm()
        {
            this.Text = "Crear factura de compra";
            this.Width = EOStyles.FormWidth;
            this.Height = EOStyles.FormHeight;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Font = EOStyles.GlobalFont;
            this.BackColor = EOStyles.c_white;
            this.StartPosition = FormStartPosition.CenterScreen;


            FormHeading formHeading = new FormHeading(this);
            FieldsPanel fieldsPanel = new FieldsPanel(this);
            FormBottom formBottom = new FormBottom(this, fieldsPanel);
        }
    }
}
