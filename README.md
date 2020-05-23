# Proiect2DotNet

Ma numesc Stefan Alexandru-Ioan, din grupa IIIA7, fac laboratorul de .NET la Marti la ora 12. Codul poate fi gasit la link-ul : 
  https://github.com/alexandrustf/Proiect2DotNet

Am realizat laboratorul 3 in continuarea laboratorului 2.
Pasii efectuati:
1. Am pornit serviciul de WCF creeat in proiectul 2.
2. Am creeat un proiect .NET CORE Web Application pentru Razor Pages
3. Am adaugat dependinta cu Add Connected Service la serviciul de WCF, numita ServiceReference1. Astfel voi avea acces la metodele
oferite de interfata MyPhotosWcfClient. Pot folosi urmatoarele metode: 
    IEnumerable<PhotoDTO> GetAllPhotos()
    IEnumerable<string> GetAllPropertiesAsStrings()
    IEnumerable<PhotoDTO> GetFilteredPhotos(string property, string value)
    void AddCustomProperty(string id, string name, string value)
    Guid CreatePhoto(string path, string name, string @event, string place, ICollection<string> persons)
    
Le voi folosi doar pe primele 3, acestea fiind doar de Get si nu de modificare a datelor asa cum este cerut in enunt.
4. Am creeat un folder Photos in folderul Pages, aici am creeat 3 pagini Razor: Index(pt. tuturor pozelor), AllProperties si FilterPhotos
5. In pagina Index, am instantiat MyPhotosWcfClient, si am apelat metoda GetAllPhotosAsync() pentru a obtine toate pozele, le-am stocat
intr-o Lista, iar acea lista o voi afisa intr-un tabel in fisierul cshtml
6. In pagina AllProperties, procedez la fel doar ca apelez GetAllPropertiesAsStringsAsync si similar le voi afisa pe toate in ordine
alfabetica intr-un tabel
7. In pagina FilterPhotos, am adaugat un formular, unde utilizatorul trebuie sa completeze numele proprietatii si valoarea 
proprietatii pe care o cauta. La apasarea butonului de submit se va apela metoda GetFilteredPhotosAsync(string property, string value).
Valorile returnate vor stocate intr-o lista si afisate intr-un tabel in pagina.
8. In final, am adaugat si rutarea in fisierul _Layour.cshtml si am adaugat si pozele cu functionalitatea in fisier.
