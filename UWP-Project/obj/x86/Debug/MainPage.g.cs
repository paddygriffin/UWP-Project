﻿#pragma checksum "C:\Users\paddy\documents\visual studio 2015\Projects\UWP-Project\UWP-Project\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "861B2689583EA90A07601C18BAEF2DC1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UWP_Project
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.progressRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 2:
                {
                    this.imgWeather = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 3:
                {
                    this.txtCel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.txtDescription = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.txtHumidity = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.txtTime = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.txtCity = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.txtLastUpdate = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.weatherButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 96 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.weatherButton).Click += this.weatherButton_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

