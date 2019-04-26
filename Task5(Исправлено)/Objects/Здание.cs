﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.ThermoObject
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Здание.
    /// </summary>
    // *** Start programmer edit section *** (Здание CustomAttributes)

    // *** End programmer edit section *** (Здание CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЗданиеE", new string[] {
            "Адрес as \'Адрес\'",
            "ТипПостройки as \'Тип постройки\'",
            "Площадь as \'Площадь\'",
            "ПлощадьВсехОТ as \'Площадь всех ОТ\'",
            "СетевойРайон as \'Сетевой район\'",
            "СетевойРайон.Название as \'Название\'"})]
    [AssociatedDetailViewAttribute("ЗданиеE", "ОбъектТеплопотребления", "ОбъектТеплопотребленияE", true, "", "Объект теплопотребления", true, new string[] {
            ""})]
    [View("ЗданиеL", new string[] {
            "Адрес as \'Адрес\'",
            "ТипПостройки as \'Тип постройки\'",
            "Площадь as \'Площадь\'",
            "ПлощадьВсехОТ as \'Площадь всех ОТ\'",
            "СетевойРайон.Название as \'Название\'"})]
    public class Здание : ICSSoft.STORMNET.DataObject
    {
        
        private string fАдрес;
        
        private string fТипПостройки;
        
        private double fПлощадь;
        
        private double fПлощадьВсехОТ;
        
        private IIS.ThermoObject.СетевойРайон fСетевойРайон;
        
        private IIS.ThermoObject.DetailArrayOfОбъектТеплопотребления fОбъектТеплопотребления;
        
        // *** Start programmer edit section *** (Здание CustomMembers)

        // *** End programmer edit section *** (Здание CustomMembers)

        
        /// <summary>
        /// Адрес.
        /// </summary>
        // *** Start programmer edit section *** (Здание.Адрес CustomAttributes)

        // *** End programmer edit section *** (Здание.Адрес CustomAttributes)
        [StrLen(255)]
        public virtual string Адрес
        {
            get
            {
                // *** Start programmer edit section *** (Здание.Адрес Get start)

                // *** End programmer edit section *** (Здание.Адрес Get start)
                string result = this.fАдрес;
                // *** Start programmer edit section *** (Здание.Адрес Get end)

                // *** End programmer edit section *** (Здание.Адрес Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Здание.Адрес Set start)

                // *** End programmer edit section *** (Здание.Адрес Set start)
                this.fАдрес = value;
                // *** Start programmer edit section *** (Здание.Адрес Set end)

                // *** End programmer edit section *** (Здание.Адрес Set end)
            }
        }
        
        /// <summary>
        /// ТипПостройки.
        /// </summary>
        // *** Start programmer edit section *** (Здание.ТипПостройки CustomAttributes)

        // *** End programmer edit section *** (Здание.ТипПостройки CustomAttributes)
        [StrLen(255)]
        public virtual string ТипПостройки
        {
            get
            {
                // *** Start programmer edit section *** (Здание.ТипПостройки Get start)

                // *** End programmer edit section *** (Здание.ТипПостройки Get start)
                string result = this.fТипПостройки;
                // *** Start programmer edit section *** (Здание.ТипПостройки Get end)

                // *** End programmer edit section *** (Здание.ТипПостройки Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Здание.ТипПостройки Set start)

                // *** End programmer edit section *** (Здание.ТипПостройки Set start)
                this.fТипПостройки = value;
                // *** Start programmer edit section *** (Здание.ТипПостройки Set end)

                // *** End programmer edit section *** (Здание.ТипПостройки Set end)
            }
        }
        
        /// <summary>
        /// Площадь.
        /// </summary>
        // *** Start programmer edit section *** (Здание.Площадь CustomAttributes)

        // *** End programmer edit section *** (Здание.Площадь CustomAttributes)
        public virtual double Площадь
        {
            get
            {
                // *** Start programmer edit section *** (Здание.Площадь Get start)

                // *** End programmer edit section *** (Здание.Площадь Get start)
                double result = this.fПлощадь;
                // *** Start programmer edit section *** (Здание.Площадь Get end)

                // *** End programmer edit section *** (Здание.Площадь Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Здание.Площадь Set start)

                // *** End programmer edit section *** (Здание.Площадь Set start)
                this.fПлощадь = value;
                // *** Start programmer edit section *** (Здание.Площадь Set end)

                // *** End programmer edit section *** (Здание.Площадь Set end)
            }
        }
        
        /// <summary>
        /// ПлощадьВсехОТ.
        /// </summary>
        // *** Start programmer edit section *** (Здание.ПлощадьВсехОТ CustomAttributes)

        // *** End programmer edit section *** (Здание.ПлощадьВсехОТ CustomAttributes)
        public virtual double ПлощадьВсехОТ
        {
            get
            {
                // *** Start programmer edit section *** (Здание.ПлощадьВсехОТ Get start)

                // *** End programmer edit section *** (Здание.ПлощадьВсехОТ Get start)
                double result = this.fПлощадьВсехОТ;
                // *** Start programmer edit section *** (Здание.ПлощадьВсехОТ Get end)

                // *** End programmer edit section *** (Здание.ПлощадьВсехОТ Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Здание.ПлощадьВсехОТ Set start)

                // *** End programmer edit section *** (Здание.ПлощадьВсехОТ Set start)
                this.fПлощадьВсехОТ = value;
                // *** Start programmer edit section *** (Здание.ПлощадьВсехОТ Set end)

                // *** End programmer edit section *** (Здание.ПлощадьВсехОТ Set end)
            }
        }
        
        /// <summary>
        /// Здание.
        /// </summary>
        // *** Start programmer edit section *** (Здание.СетевойРайон CustomAttributes)

        // *** End programmer edit section *** (Здание.СетевойРайон CustomAttributes)
        [PropertyStorage(new string[] {
                "СетевойРайон"})]
        [NotNull()]
        public virtual IIS.ThermoObject.СетевойРайон СетевойРайон
        {
            get
            {
                // *** Start programmer edit section *** (Здание.СетевойРайон Get start)

                // *** End programmer edit section *** (Здание.СетевойРайон Get start)
                IIS.ThermoObject.СетевойРайон result = this.fСетевойРайон;
                // *** Start programmer edit section *** (Здание.СетевойРайон Get end)

                // *** End programmer edit section *** (Здание.СетевойРайон Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Здание.СетевойРайон Set start)

                // *** End programmer edit section *** (Здание.СетевойРайон Set start)
                this.fСетевойРайон = value;
                // *** Start programmer edit section *** (Здание.СетевойРайон Set end)

                // *** End programmer edit section *** (Здание.СетевойРайон Set end)
            }
        }
        
        /// <summary>
        /// Здание.
        /// </summary>
        // *** Start programmer edit section *** (Здание.ОбъектТеплопотребления CustomAttributes)

        // *** End programmer edit section *** (Здание.ОбъектТеплопотребления CustomAttributes)
        public virtual IIS.ThermoObject.DetailArrayOfОбъектТеплопотребления ОбъектТеплопотребления
        {
            get
            {
                // *** Start programmer edit section *** (Здание.ОбъектТеплопотребления Get start)

                // *** End programmer edit section *** (Здание.ОбъектТеплопотребления Get start)
                if ((this.fОбъектТеплопотребления == null))
                {
                    this.fОбъектТеплопотребления = new IIS.ThermoObject.DetailArrayOfОбъектТеплопотребления(this);
                }
                IIS.ThermoObject.DetailArrayOfОбъектТеплопотребления result = this.fОбъектТеплопотребления;
                // *** Start programmer edit section *** (Здание.ОбъектТеплопотребления Get end)

                // *** End programmer edit section *** (Здание.ОбъектТеплопотребления Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Здание.ОбъектТеплопотребления Set start)

                // *** End programmer edit section *** (Здание.ОбъектТеплопотребления Set start)
                this.fОбъектТеплопотребления = value;
                // *** Start programmer edit section *** (Здание.ОбъектТеплопотребления Set end)

                // *** End programmer edit section *** (Здание.ОбъектТеплопотребления Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЗданиеE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗданиеE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗданиеE", typeof(IIS.ThermoObject.Здание));
                }
            }
            
            /// <summary>
            /// "ЗданиеL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗданиеL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗданиеL", typeof(IIS.ThermoObject.Здание));
                }
            }
        }
    }
}
