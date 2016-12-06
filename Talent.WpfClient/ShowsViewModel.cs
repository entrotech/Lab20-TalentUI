using System.Collections.ObjectModel;
using Talent.DataAccess.Ado;
using Talent.Domain;

namespace Talent.WpfClient
{
    public class ShowsViewModel : DomainViewModel<Show>
    {

        public ShowsViewModel() : base(new ShowRepository())
        {
        }

        public ObservableCollection<MpaaRating> MpaaRatings
        {
            get {
                return new ObservableCollection<MpaaRating>( 
                    LookupCache.MpaaRatings);
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

        public ObservableCollection<Person> People
        {
            get
            {
                return new ObservableCollection<Person>(
                    LookupCache.People);
            }
        }

        public ObservableCollection<Genre> Genres
        {
            get
            {
                return new ObservableCollection<Genre>(
                    LookupCache.Genres);
            }
        }

    }
}
