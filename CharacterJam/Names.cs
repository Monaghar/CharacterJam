using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterJam
{
    public static class Names
    {
        public static List<string> MaleNames
        {
            get
            {
                return MaleNames = new List<string>
                { "Adran", "Aelar", "Aramil", "Arannis",
                "Aust", "Beiro", "Berrian", "Carric", "Enialis", "Erdan", "Erevan",
                "Galinndan", "Hadarai", "Heian", "Himo", "Immeral", "Ivellios",
                "Laucian", "Mindartis", "Paelias", "Peren", "Quarion", "Riardon",
                "Rolen", "Soveliss", "Thamior", "Tharivol", "Theren", "Varis", "Adrik", "Alberich", "Baern", "Barendd", "Brottor",
                "Bruenor", "Dain", "Darrak", "Delg", "Eberk", "Einkil", "Fargrim",
                "Flint", "Gardain", "Harbek", "Kildrak", "Morgran", "Orsik",
                "Oskar", "Rangrim", "Rurik", "Taklinn", "Thoradin", "Thorin",
                "Tordek", "Traubon", "Travok", "Ulfgar", "Veit", "Vondal", "Alton", "Ander", "Cade", "Corrin", "Eldon", "Errich",
                "Finnan", "Garret", "Lindal", "Lyle", "Merric", "Milo", "Osborn",
                "Perrin", "Reed", "Roscoe", "Wellby", "Aseir", "Bardeid", "Haseid",
                "Khemed", "Mehmen", "Sudeiman", "Zasheir", "Darvin", "Dorn", "Evendur",
                "Gorstag", "Grim", "Helm", "Malark", "Morn", "Randal", "Stedd", "Bor", "Fodel", "Glar", "Grigor",
                "Igan", "Ivor", "Kosef", "Mival", "Orel", "Pavel", "Sergor", "Ander", "Blath", "Bran", "Frath",
                "Geth", "Lander", "Luth", "Malcer", "Stor", "Taman", "Urth", "Aoth", "Bareris", "Ehput-Ki",
                "Kethoth", "Mumed", "Ramas", "So-Kehur", "Thazar-De", "Urhur", "Borivik", "Faurgar", "Jandar",
                "Kanithar", "Madislak", "Ralmevik", "Shaumar", "Vladislak", "An", "Chen", "Chi", "Fai", "Jiang", "Jun",
                "Lian", "Long", "Meng", "Shan", "Shui", "Wen", "Ohn", "Anton", "Diero", "Marcon", "Pieron",
                "Rimardo", "Romero", "Salazar", "Umbero", "Arjhan", "Balasar", "Bharash", "Donaar", "Ghesh",
                "Heskan", "Kriv", "Medrash", "Mehen", "Nadarr", "Pandjed", "Patrin", "Rhogar", "Shamash", "Shedinn", "Tarhun",
                "Torinn", "Alston", "Alvyn", "Boddynock", "Brocc", "Burgell", "Dimble", "Eldon", "Erky", "Fonkin", "Frug",
                "Gerbo", "Gimble", "Glim", "Jebeddo", "Kellen", "Namfoodle", "Orryn", "Roondar", "Seebo", "Sindri", "Warryn", "Wrenn", "Zook",
                "Dench", "Feng", "Gell", "Henk", "Holg", "Imsh", "Keth", "Krusk", "Mhurren", "Ront", "Shump", "Thokk", "Akmenos", "Amnon", "Barakas",
                "Damakos", "Ekemon", "Iados", "Kairon", "Leucis", "Melech", "Mordai", "Morthos", "Pelaios", "Skamos", "Therai"};
            }
            set { }
        }

        public static List<string> FemaleNames
        {
            get
            {
                return FemaleNames = new List<string>
                {"Amber", "Artin", "Audhild", "Bardryn",
                "Dagnal", "Diesa", "Eldeth", "Falkrunn", "Finellen", "Gunnloda",
                "Gurdis", "Helja", "Hlin", "Kathra", "Kristryd", "Ilde", "Liftrasa",
                "Mardred", "Riswynn", "Sannl", "Torbera", "Torgga", "Vistra", "Adrie", "Althaea", "Anastrianna",
                "Andraste", "Antinua", "Bethrynna", "Birel", "Caelynn",
                "Drusilia", "Enna", "Felosial", "Ielenia", "Jelenneth", "Keyleth",
                "Leshanna", "Lia", "Meriele", "Mialee", "Naivara", "Quelenna",
                "Quillathe", "Sariel", "Shanairra", "Shava", "Silaqui",
                "Theirastra", "Thia", "Vadania", "Valanthe", "Xanaphia", "Andry", "Bree", "Callie", "Cora", "Euphemia",
                "Jillian", "Kithri", "Lavinia", "Lidda", "Merla", "Nedda", "Paela",
                "Portia", "Seraphina", "Shaena", "Trym", "Vani", "Verna", "Atala", "Ceidil", "Hama", "Jasmal", "Meilil", "Seipora", "Yasheira",
                "Zasheida", "Arveene", "Esvele", "Jhessail", "Kerri", "Lureene", "Miri", "Rowan", "Shandri", "Tessele",
                "Alethra", "Kara", "Katernin", "Mara", "Natali", "Olma", "Tana", "Zora", "Amafrey", "Betha", "Cefrey", "Kethra", "Mara", "Olga",
                "Silifrey", "Westra", "Arizima", "Chathi", "Nephis", "Nulara", "Murithi", "Sefris", "Thola", "Umara", "Zolis",
                "Fyevarra", "Hulmarra", "Immith", "Imzel", "Navarra", "Shevarra", "Tammith", "Yuldra", "Bai", "Chao", "Jia", "Lei", "Mei", "Qiao", "Shui", "Tai",
                "Balama", "Dona", "Faila", "Jalana", "Luisa", "Marta", "Quara", "Selise", "Vonda", "Akra", "Biri", "Daar", "Farideh", "Harann",
                "Flavilar", "Jheri", "Kava", "Korinn", "Mishann", "Nala", "Perra", "Raiann", "Sora", "Surina", "Thava", "Bimpnottin", "Breena", "Caramip", "Carlin",
                "Donella", "Duvamil", "Ella", "Ellyjobell", "Ellywick", "Lilli", "Loopmottin", "Lorilla", "Mardnab", "Nissa", "Nyx", "Oda", "Orla", "Roywyn",
                "Shamil", "Tana", "Waywocket", "Zanna", "Baggi", "Emen", "Engong", "Kansif", "Myev", "Neega", "Ovak", "Ownka", "Shautha", "Sutha", "Vola",
                "Volen", "Yevelda", "Akta", "Anakis", "Bryseis", "Criella", "Damaia", "Ea", "Kallista", "Lerissa", "Makaria", "Nemeia", "Orianna", "Phelaia", "Rieta"};
            }
            set { }
        }

        public static List<string> LastNames
        {
            get
            {
                return LastNames = new List<string>
                {"Balderk", "Battlehammer", "Brawnanvil",
                "Dankil", "Fireforge", "Frostbeard", "Gorunn", "Holderhek",
                "Ironfist", "Loderr", "Lutgehr", "Rumnaheim", "Strakeln",
                "Torunn", "Ungart", "Amakiir", "Amastacia", "Galanodel", "Holimion", "Ilphelkiir", "Liadon"," Meliamne", "Nai'lo" , "Siannodel",
                "Brushgather", "Goodbarrel", "Greenbottle", "High-hill", "Hilltopple", "Leagallow", "Tealeaf", "Thorngage", "Tosscobble", "Underbough",
                "Basha", "Dumein", "Jassan", "Khalid", "Mostana", "Pashar", "Rein", "Amblecrown", "Buckman", "Dundragon", "Evenwood", "Greycastle", "Tallstag",
                "Bersk", "Chernin", "Dotsk", "Kulenov", "Marsk", "Nemetsk", "Shemov", "Starag", "Brightwood", "Helder", "Hornraven", "Lackman", "Stormwind", "Windrivver",
                "Ankhalab", "Anskuld", "Fezim", "Hahpet", "Nathandem", "Sepret", "Uuthrakt", "Chergoba", "Dyernina", "Iltazyara", "Murnyethara",
                "Stayanoga", "Ulmokina", "Chien", "Huang", "Kao", "Kung", "Lao", "Ling", "Mei", "Pin", "Shin", "Sum", "Tan", "Wan", "Agosto", "Astorio", "Calabra", "Domine",
                "Falone", "Marivaldi", "Pisacar", "Ramondo", "Myastan", "Yarjerit", "Kimbatuul", "Kerrhylon", "Turnuroth", "Beren", "Daergel", "Folkor", "Garrick", "Nackle",
                "Murnig", "Ningel", "Raulnor", "Scheppen", "Timbers", "Turen"};
            }
            set { }
        }
    }
}