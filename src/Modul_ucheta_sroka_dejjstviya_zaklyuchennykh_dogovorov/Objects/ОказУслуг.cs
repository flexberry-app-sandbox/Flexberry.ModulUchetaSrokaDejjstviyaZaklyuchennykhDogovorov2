﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Оказ услуг.
    /// </summary>
    // *** Start programmer edit section *** (ОказУслуг CustomAttributes)

    // *** End programmer edit section *** (ОказУслуг CustomAttributes)
    [AutoAltered()]
    [Caption("Оказ услуг")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ОказаниеУслугE", new string[] {
            "Дата as \'Дата\'",
            "Услуги as \'Наименование\'",
            "Услуги.ЗатрВрем as \'Затраченное время\'",
            "Услуги.ЕдВремени as \'Единица времени\'"})]
    [MasterViewDefineAttribute("ОказаниеУслугE", "Услуги", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    public class ОказУслуг : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДата;
        
        private IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.Услуги fУслуги;
        
        private IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.РасчетОстВрем fРасчетОстВрем;
        
        // *** Start programmer edit section *** (ОказУслуг CustomMembers)

        // *** End programmer edit section *** (ОказУслуг CustomMembers)

        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (ОказУслуг.Дата CustomAttributes)

        // *** End programmer edit section *** (ОказУслуг.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (ОказУслуг.Дата Get start)

                // *** End programmer edit section *** (ОказУслуг.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (ОказУслуг.Дата Get end)

                // *** End programmer edit section *** (ОказУслуг.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОказУслуг.Дата Set start)

                // *** End programmer edit section *** (ОказУслуг.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (ОказУслуг.Дата Set end)

                // *** End programmer edit section *** (ОказУслуг.Дата Set end)
            }
        }
        
        /// <summary>
        /// Оказ услуг.
        /// </summary>
        // *** Start programmer edit section *** (ОказУслуг.Услуги CustomAttributes)

        // *** End programmer edit section *** (ОказУслуг.Услуги CustomAttributes)
        [PropertyStorage(new string[] {
                "Услуги"})]
        [NotNull()]
        public virtual IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.Услуги Услуги
        {
            get
            {
                // *** Start programmer edit section *** (ОказУслуг.Услуги Get start)

                // *** End programmer edit section *** (ОказУслуг.Услуги Get start)
                IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.Услуги result = this.fУслуги;
                // *** Start programmer edit section *** (ОказУслуг.Услуги Get end)

                // *** End programmer edit section *** (ОказУслуг.Услуги Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОказУслуг.Услуги Set start)

                // *** End programmer edit section *** (ОказУслуг.Услуги Set start)
                this.fУслуги = value;
                // *** Start programmer edit section *** (ОказУслуг.Услуги Set end)

                // *** End programmer edit section *** (ОказУслуг.Услуги Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.РасчетОстВрем.
        /// </summary>
        // *** Start programmer edit section *** (ОказУслуг.РасчетОстВрем CustomAttributes)

        // *** End programmer edit section *** (ОказУслуг.РасчетОстВрем CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "РасчетОстВрем"})]
        public virtual IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.РасчетОстВрем РасчетОстВрем
        {
            get
            {
                // *** Start programmer edit section *** (ОказУслуг.РасчетОстВрем Get start)

                // *** End programmer edit section *** (ОказУслуг.РасчетОстВрем Get start)
                IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.РасчетОстВрем result = this.fРасчетОстВрем;
                // *** Start programmer edit section *** (ОказУслуг.РасчетОстВрем Get end)

                // *** End programmer edit section *** (ОказУслуг.РасчетОстВрем Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ОказУслуг.РасчетОстВрем Set start)

                // *** End programmer edit section *** (ОказУслуг.РасчетОстВрем Set start)
                this.fРасчетОстВрем = value;
                // *** Start programmer edit section *** (ОказУслуг.РасчетОстВрем Set end)

                // *** End programmer edit section *** (ОказУслуг.РасчетОстВрем Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ОказаниеУслугE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ОказаниеУслугE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ОказаниеУслугE", typeof(IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.ОказУслуг));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of ОказУслуг.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfОказУслуг CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfОказУслуг CustomAttributes)
    public class DetailArrayOfОказУслуг : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.DetailArrayOfОказУслуг members)

        // *** End programmer edit section *** (IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.DetailArrayOfОказУслуг members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ОказУслуг by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ОказУслуг.
        /// </summary>
        public DetailArrayOfОказУслуг(IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.РасчетОстВрем fРасчетОстВрем) : 
                base(typeof(ОказУслуг), ((ICSSoft.STORMNET.DataObject)(fРасчетОстВрем)))
        {
        }
        
        public IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.ОказУслуг this[int index]
        {
            get
            {
                return ((IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.ОказУслуг)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.ОказУслуг dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
