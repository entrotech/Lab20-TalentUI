using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Talent.DataAccess.Ado;
using Talent.Domain;
using UclaExt.Common.BaseClasses;

namespace Talent.WpfClient
{
    public class PeopleViewModel : DomainViewModel<Person>
    {

        public PeopleViewModel() : base( new PersonRepository())
        {
        }

        #region Lookup Lists

        public ObservableCollection<HairColor> HairColors
        {
            get {
                return new ObservableCollection<HairColor>( 
                    LookupCache.HairColors);
            }
        }

        public ObservableCollection<EyeColor> EyeColors
        {
            get
            {
                return new ObservableCollection<EyeColor>(
                    LookupCache.EyeColors);
            }
        }

        public ObservableCollection<CreditType> CreditTypes
        {
            get
            {
                return new ObservableCollection<CreditType>(
                    LookupCache.CreditTypes);
            }
        }

        public ObservableCollection<Show> Shows
        {
            get
            {
                return new ObservableCollection<Show>(
                    LookupCache.Shows);
            }
        }

        #endregion

    }
}
