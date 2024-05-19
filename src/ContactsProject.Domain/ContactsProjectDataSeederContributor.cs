using System;
using System.Threading.Tasks;
using ContactsProject.Contacts;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace ContactsProject;

public class ContactsProjectDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Contact, int> _contactRepository;

    public ContactsProjectDataSeederContributor(
        IRepository<Contact, int> contactRepository)
    {
        _contactRepository = contactRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _contactRepository.GetCountAsync() <= 0)
        {
            await _contactRepository.InsertAsync(
                new Contact
                {
                    FirstName = "Lloyd",
                    LastName = "Forte",
                    Birthday = new DateTime(1969, 8, 26, 0, 0, 0),
                    PhoneNumber = "544-9221",
                    Email = "lforte@email.com",
                    StreetAddress = "4727 Arron Smith Drive",
                    City = "Honolulu",
                    State = "HI",
                    Zip = 96813,
                },
                autoSave: true
            );
            await _contactRepository.InsertAsync(
                new Contact
                {
                    FirstName = "Brenna",
                    LastName = "Duran",
                    Birthday = new DateTime(1988, 6, 16, 0, 0, 0),
                    PhoneNumber = "291-6894",
                    Email = "bduran@email.com",
                    StreetAddress = "2886 Veltri Drive",
                    City = "Mentasta",
                    State = "AK",
                    Zip = 99780,
                },
                autoSave: true
            );
            await _contactRepository.InsertAsync(
                new Contact
                {
                    FirstName = "Ramon",
                    LastName = "Bell",
                    Birthday = new DateTime(1992, 8, 6, 0, 0, 0),
                    PhoneNumber = "452-1062",
                    Email = "rbell@email.com",
                    StreetAddress = "1101 Ford Street",
                    City = "San Jose",
                    State = "CA",
                    Zip = 95131,
                },
                autoSave: true
            );
            await _contactRepository.InsertAsync(
                new Contact
                {
                    FirstName = "Leonard",
                    LastName = "Mooney",
                    Birthday = new DateTime(1954, 12, 27, 0, 0, 0),
                    PhoneNumber = "361-1642",
                    Email = "lmooney@email.com",
                    StreetAddress = "4581 Lochmere Lane",
                    City = "Norwalk",
                    State = "CT",
                    Zip = 6851,
                },
                autoSave: true
            );
            await _contactRepository.InsertAsync(
                new Contact
                {
                    FirstName = "Dominique",
                    LastName = "Monaco",
                    Birthday = new DateTime(1977, 11, 26, 0, 0, 0),
                    PhoneNumber = "986-8317",
                    Email = "dmonaco@email.com",
                    StreetAddress = "2261 James Avenue",
                    City = "Macedon",
                    State = "NY",
                    Zip = 14502,
                },
                autoSave: true
            );
            await _contactRepository.InsertAsync(
                new Contact
                {
                    FirstName = "Phillip",
                    LastName = "White",
                    Birthday = new DateTime(1967, 8, 31, 0, 0, 0),
                    PhoneNumber = "241-5333",
                    Email = "pwhite@email.com",
                    StreetAddress = "4815 Green Gate Lane",
                    City = "Baltimore",
                    State = "MD",
                    Zip = 21201,
                },
                autoSave: true
            );
            await _contactRepository.InsertAsync(
                new Contact
                {
                    FirstName = "Mollie",
                    LastName = "Watts",
                    Birthday = new DateTime(1983, 6, 26, 0, 0, 0),
                    PhoneNumber = "681-8740",
                    Email = "mwatts@email.com",
                    StreetAddress = "4177 Friendship Lane",
                    City = "San Martin",
                    State = "CA",
                    Zip = 95046,
                },
                autoSave: true
            );
            await _contactRepository.InsertAsync(
                new Contact
                {
                    FirstName = "Marissa",
                    LastName = "Pangle",
                    Birthday = new DateTime(1981, 10, 16, 0, 0, 0),
                    PhoneNumber = "528-6349",
                    Email = "mpangle@email.com",
                    StreetAddress = "2615 Mudlick Road",
                    City = "Millwood",
                    State = "WA",
                    Zip = 99212,
                },
                autoSave: true
            );
            await _contactRepository.InsertAsync(
                new Contact
                {
                    FirstName = "Robert",
                    LastName = "Davis",
                    Birthday = new DateTime(1992, 3, 25, 0, 0, 0),
                    PhoneNumber = "523-0201",
                    Email = "rdavis@email.com",
                    StreetAddress = "2297 Young Road",
                    City = "Idaho Falls",
                    State = "ID",
                    Zip = 83402,
                },
                autoSave: true
            );
            await _contactRepository.InsertAsync(
                new Contact
                {
                    FirstName = "Shawn",
                    LastName = "Warwick",
                    Birthday = new DateTime(1967, 2, 7, 0, 0, 0),
                    PhoneNumber = "492-2600",
                    Email = "swarwick@email.com",
                    StreetAddress = "1859 Poe Lane",
                    City = "Kansas City",
                    State = "KS",
                    Zip = 66215,
                },
                autoSave: true
            );
        }
    }
}
