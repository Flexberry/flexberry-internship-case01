﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Task6
{
    using System;
    using System.Xml;
    
    
    // *** Start programmer edit section *** (Using statements)
    using System.Collections;

    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.FunctionalLanguage;
    using ICSSoft.STORMNET.FunctionalLanguage.SQLWhere;

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// ЦБкодДублиУСплощадиОТ.
    /// </summary>
    // *** Start programmer edit section *** (ЦБкодДублиУСплощадиОТ CustomAttributes)

    // *** End programmer edit section *** (ЦБкодДублиУСплощадиОТ CustomAttributes)
    [ICSSoft.STORMNET.AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class ЦБкодДублиУСплощадиОТ : ICSSoft.STORMNET.Business.BusinessServer
    {
        
        // *** Start programmer edit section *** (ЦБкодДублиУСплощадиОТ CustomMembers)

        // *** End programmer edit section *** (ЦБкодДублиУСплощадиОТ CustomMembers)

        
        // *** Start programmer edit section *** (OnUpdateОбъектТеплопотребления CustomAttributes)

        // *** End programmer edit section *** (OnUpdateОбъектТеплопотребления CustomAttributes)
        public virtual ICSSoft.STORMNET.DataObject[] OnUpdateОбъектТеплопотребления(IIS.Task6.ОбъектТеплопотребления UpdatedObject)
        {
            // *** Start programmer edit section *** (OnUpdateОбъектТеплопотребления)
            

            //Генерируем цифро-буквенный код для объекта теплопотребления
            string QRcode = CreateCode.FirstCreateCode.GenerateCode(UpdatedObject.Название, UpdatedObject.ДатаУстановки, UpdatedObject.Потребитель.ЛицевойСчёт);
            UpdatedObject.ЦБкод = QRcode;


            //Проверка на дублирование участков сети
            string DuplicateNetworksError = string.Empty;
            bool IsDuplicatedNetwork = false;
            for (int i = 0; i < UpdatedObject.УчастокСети.Count; i++)
            {
                for (int j = 0; j < UpdatedObject.УчастокСети.Count; j++)
                {
                    if (!UpdatedObject.УчастокСети[i].Equals(UpdatedObject.УчастокСети[j]) && UpdatedObject.УчастокСети[i].Номер == UpdatedObject.УчастокСети[j].Номер && 
                        UpdatedObject.УчастокСети[i].ТипПрокладки == UpdatedObject.УчастокСети[j].ТипПрокладки)
                    {
                        DuplicateNetworksError = "Обнаружены дубли участков сети";
                        IsDuplicatedNetwork = true;
                    }
                }
            }
            if (IsDuplicatedNetwork) throw new Exception(DuplicateNetworksError);


            //Перевычисление площадей объектов теплопотребления в здании
            UpdatedObject.Здание.ПлощадьВсехОТ = 0;
            for (int i = 0; i < UpdatedObject.Здание.ОбъектТеплопотребления.Count; i++)
            {
                UpdatedObject.Здание.ПлощадьВсехОТ += UpdatedObject.Площадь;
            }

            return new ICSSoft.STORMNET.DataObject[0];
            // *** End programmer edit section *** (OnUpdateОбъектТеплопотребления)
        }
    }
}
