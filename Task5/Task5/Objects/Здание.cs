﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Task5
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
    public class Здание : ICSSoft.STORMNET.DataObject
    {
        
        private string fАдрес;
        
        private string fТипПостройки;
        
        private string fПлощадь;
        
        private IIS.Task5.СетевойРайон fСетевойРайон;
        
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
        [StrLen(255)]
        public virtual string Площадь
        {
            get
            {
                // *** Start programmer edit section *** (Здание.Площадь Get start)

                // *** End programmer edit section *** (Здание.Площадь Get start)
                string result = this.fПлощадь;
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
        /// Здание.
        /// </summary>
        // *** Start programmer edit section *** (Здание.СетевойРайон CustomAttributes)

        // *** End programmer edit section *** (Здание.СетевойРайон CustomAttributes)
        [PropertyStorage(new string[] {
                "СетевойРайон"})]
        [NotNull()]
        public virtual IIS.Task5.СетевойРайон СетевойРайон
        {
            get
            {
                // *** Start programmer edit section *** (Здание.СетевойРайон Get start)

                // *** End programmer edit section *** (Здание.СетевойРайон Get start)
                IIS.Task5.СетевойРайон result = this.fСетевойРайон;
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
    }
}
