﻿/****************************************************************************
**						 SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				 BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ 
**				    NESNEYE DAYALI PROGRAMLAMA DERSİ
**					     2019-2020 YAZ DÖNEMİ 
**	
**				PROJE NUMARASI.........: 01
**				ÖĞRENCİ ADI............: YASER BİN HUMAİDAH 
**				ÖĞRENCİ NUMARASI.......: B171200560
**              DERSİN ALINDIĞI GRUP...: A
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akaryakıt_Otomasyon
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
