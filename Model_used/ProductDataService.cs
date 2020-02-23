using System;
using System.Collections.Generic;
using System.Text;

namespace Model_used
{
    public class ProductDataService : IDataService<Product>
    {
        private List<Product> products;

        public ProductDataService()
        {
            products = new List<Product>()
            {
                new Product() {UPC = "523438", Code = "TUE354", ShortDescription = "cubilia Curae; Donec tincidunt.", Description = "pede, nonummy ut, molestie in, tempus eu, ligula. Aenean",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "536976", Code = "CWQ999", ShortDescription = "enim. Nunc", Description = "malesuada malesuada. Integer id magna et ipsum cursus vestibulum. Mauris",Category = "Drugs", PicturePath = "images/product.png"},
                new Product() {UPC = "762723", Code = "XVA415", ShortDescription = "nisi a", Description = "cursus et, magna. Praesent interdum ligula eu enim. Etiam",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "146509", Code = "YWC365", ShortDescription = "Quisque ornare tortor", Description = "vel, venenatis vel, faucibus id, libero. Donec consectetuer mauris",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "911706", Code = "LSF234", ShortDescription = "luctus vulputate, nisi", Description = "et ultrices posuere cubilia Curae;",Category = "Clothing", PicturePath = "images/product.png"},
                new Product() {UPC = "228914", Code = "NDN489", ShortDescription = "sociis natoque", Description = "diam at pretium aliquet, metus urna convallis",Category = "Drugs", PicturePath = "images/product.png"},
                new Product() {UPC = "345007", Code = "GBZ176", ShortDescription = "in felis. Nulla", Description = "ac risus. Morbi metus. Vivamus euismod urna.",Category = "Drugs", PicturePath = "images/product.png"},
                new Product() {UPC = "707756", Code = "FAW714", ShortDescription = "in faucibus orci luctus", Description = "hendrerit consectetuer, cursus et, magna. Praesent interdum ligula eu enim.",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "834773", Code = "VMM742", ShortDescription = "et magnis dis", Description = "urna. Nullam lobortis quam a felis ullamcorper viverra. Maecenas iaculis",Category = "Clothing", PicturePath = "images/product.png"},
                new Product() {UPC = "754822", Code = "JZG819", ShortDescription = "elit, pretium et,", Description = "Integer tincidunt aliquam arcu. Aliquam ultrices iaculis odio. Nam",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "943275", Code = "KBJ597", ShortDescription = "aliquet, sem", Description = "adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut",Category = "Hardware", PicturePath = "images/product.png"},
                new Product() {UPC = "322576", Code = "DZT371", ShortDescription = "ornare. In", Description = "Phasellus in felis. Nulla tempor augue ac",Category = "Clothing", PicturePath = "images/product.png"},
                new Product() {UPC = "119448", Code = "XJM693", ShortDescription = "Vivamus euismod", Description = "pretium aliquet, metus urna convallis erat, eget tincidunt",Category = "Hardware", PicturePath = "images/product.png"},
                new Product() {UPC = "730891", Code = "MMY364", ShortDescription = "sapien. Cras dolor", Description = "vestibulum. Mauris magna. Duis dignissim tempor arcu. Vestibulum ut eros",Category = "Clothing", PicturePath = "images/product.png"},
                new Product() {UPC = "259402", Code = "ACA897", ShortDescription = "mollis nec, cursus a,", Description = "eleifend, nunc risus varius orci, in consequat enim diam vel",Category = "Drugs", PicturePath = "images/product.png"},
                new Product() {UPC = "303251", Code = "PFF636", ShortDescription = "Sed malesuada augue ut", Description = "aliquet vel, vulputate eu, odio.",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "492491", Code = "CYV351", ShortDescription = "Nam ac nulla. In", Description = "ultrices posuere cubilia Curae;",Category = "Hardware", PicturePath = "images/product.png"},
                new Product() {UPC = "951243", Code = "UBY236", ShortDescription = "Curabitur dictum. Phasellus", Description = "eget, dictum placerat, augue. Sed molestie. Sed id risus",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "320726", Code = "BCV239", ShortDescription = "lacinia vitae, sodales at,", Description = "tempor lorem, eget mollis lectus pede",Category = "Drugs", PicturePath = "images/product.png"},
                new Product() {UPC = "144441", Code = "RCI621", ShortDescription = "lacus. Cras interdum.", Description = "Sed id risus quis diam luctus lobortis. Class aptent",Category = "Clothing", PicturePath = "images/product.png"},
                new Product() {UPC = "730982", Code = "IOI451", ShortDescription = "semper, dui lectus", Description = "vel lectus. Cum sociis natoque",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "189671", Code = "OMM777", ShortDescription = "et ipsum cursus vestibulum.", Description = "quam quis diam. Pellentesque habitant morbi tristique",Category = "Hardware", PicturePath = "images/product.png"},
                new Product() {UPC = "423148", Code = "DSY688", ShortDescription = "tempor lorem,", Description = "in lobortis tellus justo sit amet nulla. Donec non justo.",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "593819", Code = "TOO234", ShortDescription = "dignissim lacus.", Description = "montes, nascetur ridiculus mus. Proin",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "676350", Code = "JLK988", ShortDescription = "urna justo", Description = "sociosqu ad litora torquent per conubia nostra,",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "614105", Code = "WSF638", ShortDescription = "lacus. Etiam bibendum fermentum", Description = "magna. Ut tincidunt orci",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "933192", Code = "SKX599", ShortDescription = "Quisque libero lacus,", Description = "laoreet, libero et tristique pellentesque, tellus sem mollis",Category = "Hardware", PicturePath = "images/product.png"},
                new Product() {UPC = "365557", Code = "FNF818", ShortDescription = "faucibus lectus,", Description = "lobortis ultrices. Vivamus rhoncus. Donec est. Nunc ullamcorper, velit in",Category = "Hardware", PicturePath = "images/product.png"},
                new Product() {UPC = "297026", Code = "SGX461", ShortDescription = "dolor quam, elementum", Description = "In ornare sagittis felis. Donec",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "429457", Code = "VEP669", ShortDescription = "nec, euismod in, dolor.", Description = "non, vestibulum nec, euismod in, dolor. Fusce",Category = "Hardware", PicturePath = "images/product.png"},
                new Product() {UPC = "960083", Code = "PPR756", ShortDescription = "tincidunt dui augue", Description = "id nunc interdum feugiat. Sed nec metus facilisis",Category = "Hardware", PicturePath = "images/product.png"},
                new Product() {UPC = "212740", Code = "NNE521", ShortDescription = "et risus. Quisque", Description = "faucibus id, libero. Donec",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "271197", Code = "HHW964", ShortDescription = "velit. Cras lorem lorem,", Description = "sociis natoque penatibus et magnis dis parturient montes, nascetur",Category = "Clothing", PicturePath = "images/product.png"},
                new Product() {UPC = "666742", Code = "OEZ681", ShortDescription = "sociis natoque penatibus et", Description = "facilisis facilisis, magna tellus faucibus leo, in",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "556285", Code = "RMG458", ShortDescription = "blandit congue.", Description = "turpis vitae purus gravida sagittis. Duis gravida. Praesent",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "788430", Code = "NKL512", ShortDescription = "blandit enim consequat", Description = "pretium et, rutrum non, hendrerit id, ante. Nunc mauris sapien,",Category = "Hardware", PicturePath = "images/product.png"},
                new Product() {UPC = "533207", Code = "PTD893", ShortDescription = "faucibus orci luctus et", Description = "convallis est, vitae sodales nisi magna sed dui.",Category = "Hardware", PicturePath = "images/product.png"},
                new Product() {UPC = "527368", Code = "XAL773", ShortDescription = "orci, adipiscing non, luctus", Description = "vitae sodales nisi magna sed dui. Fusce aliquam,",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "813413", Code = "TTK131", ShortDescription = "lorem. Donec elementum,", Description = "ullamcorper, nisl arcu iaculis",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "465468", Code = "YDH783", ShortDescription = "metus. Aenean sed", Description = "magna. Phasellus dolor elit, pellentesque a, facilisis non, bibendum sed,",Category = "Drugs", PicturePath = "images/product.png"},
                new Product() {UPC = "949748", Code = "YWW591", ShortDescription = "quis accumsan", Description = "ligula. Nullam feugiat placerat",Category = "Clothing", PicturePath = "images/product.png"},
                new Product() {UPC = "906302", Code = "BBN941", ShortDescription = "Sed dictum. Proin", Description = "Vestibulum accumsan neque et nunc. Quisque",Category = "Hardware", PicturePath = "images/product.png"},
                new Product() {UPC = "964056", Code = "GQU772", ShortDescription = "egestas. Fusce aliquet magna", Description = "Aenean eget magna. Suspendisse tristique neque venenatis lacus. Etiam bibendum",Category = "Hardware", PicturePath = "images/product.png"},
                new Product() {UPC = "966599", Code = "HJO237", ShortDescription = "Ut sagittis", Description = "convallis ligula. Donec luctus aliquet odio.",Category = "Drugs", PicturePath = "images/product.png"},
                new Product() {UPC = "103053", Code = "YYS417", ShortDescription = "diam at pretium", Description = "Mauris blandit enim consequat purus. Maecenas libero est, congue a,",Category = "Drugs", PicturePath = "images/product.png"},
                new Product() {UPC = "509399", Code = "CEH256", ShortDescription = "tellus. Phasellus elit pede,", Description = "Fusce mi lorem, vehicula et, rutrum",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "662406", Code = "SVK239", ShortDescription = "placerat, orci lacus", Description = "parturient montes, nascetur ridiculus mus. Proin vel",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "693337", Code = "DLC216", ShortDescription = "dictum placerat, augue. Sed", Description = "malesuada fringilla est. Mauris eu turpis.",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "205003", Code = "ZDF178", ShortDescription = "ornare egestas ligula.", Description = "in consequat enim diam vel arcu. Curabitur ut",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "504490", Code = "ZQM286", ShortDescription = "lobortis. Class aptent", Description = "adipiscing ligula. Aenean gravida nunc sed pede.",Category = "Drugs", PicturePath = "images/product.png"},
                new Product() {UPC = "962953", Code = "BOR339", ShortDescription = "malesuada vel,", Description = "pede ac urna. Ut tincidunt vehicula risus. Nulla eget metus",Category = "Clothing", PicturePath = "images/product.png"},
                new Product() {UPC = "578585", Code = "FZD797", ShortDescription = "dui quis accumsan convallis,", Description = "libero. Proin mi. Aliquam gravida mauris",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "506506", Code = "YCF835", ShortDescription = "at fringilla", Description = "diam. Pellentesque habitant morbi tristique senectus et netus",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "726518", Code = "IXT315", ShortDescription = "ipsum porta elit,", Description = "elit. Nulla facilisi. Sed",Category = "Drugs", PicturePath = "images/product.png"},
                new Product() {UPC = "415477", Code = "XMQ582", ShortDescription = "Phasellus libero", Description = "luctus ut, pellentesque eget, dictum placerat, augue.",Category = "Drugs", PicturePath = "images/product.png"},
                new Product() {UPC = "587108", Code = "UDN329", ShortDescription = "et magnis dis", Description = "Proin vel arcu eu odio tristique pharetra. Quisque ac",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "354517", Code = "SSU516", ShortDescription = "molestie pharetra nibh.", Description = "enim. Etiam gravida molestie arcu. Sed eu nibh",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "375659", Code = "WFA482", ShortDescription = "velit justo", Description = "venenatis vel, faucibus id,",Category = "Drugs", PicturePath = "images/product.png"},
                new Product() {UPC = "793417", Code = "BAU181", ShortDescription = "Proin vel", Description = "egestas a, scelerisque sed, sapien. Nunc pulvinar arcu et pede.",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "971100", Code = "VBX277", ShortDescription = "Ut tincidunt vehicula risus.", Description = "adipiscing. Mauris molestie pharetra nibh. Aliquam ornare,",Category = "Drugs", PicturePath = "images/product.png"},
                new Product() {UPC = "181731", Code = "WUZ769", ShortDescription = "Praesent eu nulla", Description = "vulputate, nisi sem semper erat, in consectetuer ipsum",Category = "Drugs", PicturePath = "images/product.png"},
                new Product() {UPC = "599878", Code = "JKE847", ShortDescription = "condimentum. Donec at arcu.", Description = "vehicula aliquet libero. Integer in magna. Phasellus",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "497968", Code = "ANH395", ShortDescription = "elementum purus,", Description = "ac risus. Morbi metus. Vivamus euismod urna.",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "554777", Code = "BML235", ShortDescription = "Phasellus elit", Description = "iaculis nec, eleifend non, dapibus",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "617338", Code = "IDO345", ShortDescription = "at lacus. Quisque purus", Description = "a odio semper cursus. Integer mollis. Integer tincidunt aliquam",Category = "Hardware", PicturePath = "images/product.png"},
                new Product() {UPC = "935834", Code = "UNI116", ShortDescription = "nisi. Cum sociis", Description = "Phasellus in felis. Nulla tempor augue ac ipsum. Phasellus",Category = "Clothing", PicturePath = "images/product.png"},
                new Product() {UPC = "561866", Code = "RKE564", ShortDescription = "Quisque porttitor", Description = "scelerisque neque sed sem egestas",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "989383", Code = "AQS814", ShortDescription = "Nulla tempor augue", Description = "Phasellus dapibus quam quis diam. Pellentesque habitant morbi",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "220848", Code = "QFO194", ShortDescription = "imperdiet, erat", Description = "arcu iaculis enim, sit",Category = "Drugs", PicturePath = "images/product.png"},
                new Product() {UPC = "763853", Code = "PEK412", ShortDescription = "diam at pretium", Description = "mauris ipsum porta elit, a feugiat",Category = "Clothing", PicturePath = "images/product.png"},
                new Product() {UPC = "207497", Code = "ANA654", ShortDescription = "luctus lobortis. Class aptent", Description = "dolor. Nulla semper tellus id nunc",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "585484", Code = "DAT732", ShortDescription = "enim commodo hendrerit. Donec", Description = "mauris blandit mattis. Cras eget nisi dictum augue",Category = "Clothing", PicturePath = "images/product.png"},
                new Product() {UPC = "660482", Code = "ZCN454", ShortDescription = "arcu. Vestibulum ante", Description = "ante. Vivamus non lorem vitae",Category = "Hardware", PicturePath = "images/product.png"},
                new Product() {UPC = "741368", Code = "MVB595", ShortDescription = "a, enim. Suspendisse", Description = "pede, malesuada vel, venenatis vel, faucibus id, libero. Donec",Category = "Hardware", PicturePath = "images/product.png"},
                new Product() {UPC = "608315", Code = "JTD349", ShortDescription = "Praesent interdum ligula eu", Description = "et tristique pellentesque, tellus",Category = "Clothing", PicturePath = "images/product.png"},
                new Product() {UPC = "183967", Code = "YWQ564", ShortDescription = "lectus rutrum", Description = "rutrum magna. Cras convallis convallis dolor.",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "198995", Code = "XQQ312", ShortDescription = "Nulla eu", Description = "luctus sit amet, faucibus ut, nulla.",Category = "Clothing", PicturePath = "images/product.png"},
                new Product() {UPC = "218551", Code = "YGE572", ShortDescription = "massa. Mauris", Description = "odio. Phasellus at augue",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "129076", Code = "WOF679", ShortDescription = "Nulla interdum.", Description = "porttitor eros nec tellus. Nunc lectus pede,",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "576793", Code = "ALK921", ShortDescription = "ullamcorper viverra. Maecenas", Description = "quis lectus. Nullam suscipit, est ac facilisis facilisis, magna tellus",Category = "Drugs", PicturePath = "images/product.png"},
                new Product() {UPC = "279189", Code = "HVU571", ShortDescription = "sagittis felis.", Description = "ultricies dignissim lacus. Aliquam rutrum lorem ac risus. Morbi",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "868803", Code = "LZZ424", ShortDescription = "libero lacus,", Description = "tellus lorem eu metus.",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "360716", Code = "NEI885", ShortDescription = "congue. In scelerisque", Description = "tortor, dictum eu, placerat",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "856699", Code = "CKN615", ShortDescription = "pharetra. Quisque ac", Description = "ipsum cursus vestibulum. Mauris magna.",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "487392", Code = "CJF615", ShortDescription = "sit amet", Description = "dapibus ligula. Aliquam erat volutpat. Nulla dignissim. Maecenas ornare",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "390804", Code = "DJB164", ShortDescription = "hendrerit consectetuer, cursus et,", Description = "tristique senectus et netus",Category = "Clothing", PicturePath = "images/product.png"},
                new Product() {UPC = "797985", Code = "GIV434", ShortDescription = "tincidunt adipiscing.", Description = "eget, ipsum. Donec sollicitudin adipiscing ligula.",Category = "Clothing", PicturePath = "images/product.png"},
                new Product() {UPC = "561585", Code = "LKA356", ShortDescription = "mi fringilla mi lacinia", Description = "non quam. Pellentesque habitant",Category = "Hardware", PicturePath = "images/product.png"},
                new Product() {UPC = "894857", Code = "XUQ412", ShortDescription = "ac mi eleifend", Description = "euismod ac, fermentum vel, mauris. Integer sem elit, pharetra ut,",Category = "Drugs", PicturePath = "images/product.png"},
                new Product() {UPC = "412060", Code = "IBK593", ShortDescription = "sodales. Mauris blandit enim", Description = "lorem fringilla ornare placerat, orci lacus vestibulum",Category = "Clothing", PicturePath = "images/product.png"},
                new Product() {UPC = "304847", Code = "WMM427", ShortDescription = "ipsum nunc id", Description = "luctus aliquet odio. Etiam ligula tortor, dictum eu,",Category = "Hardware", PicturePath = "images/product.png"},
                new Product() {UPC = "895822", Code = "GBV677", ShortDescription = "ridiculus mus. Proin vel", Description = "ridiculus mus. Proin vel arcu eu odio tristique",Category = "Drugs", PicturePath = "images/product.png"},
                new Product() {UPC = "411570", Code = "JBO153", ShortDescription = "at auctor ullamcorper,", Description = "gravida mauris ut mi. Duis risus odio, auctor vitae,",Category = "Clothing", PicturePath = "images/product.png"},
                new Product() {UPC = "289174", Code = "GWP828", ShortDescription = "Nullam feugiat", Description = "ligula. Aenean gravida nunc sed pede. Cum",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "604560", Code = "XKS444", ShortDescription = "Proin non massa non", Description = "tincidunt pede ac urna. Ut tincidunt vehicula",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "154057", Code = "WHT484", ShortDescription = "diam vel arcu. Curabitur", Description = "nulla. Cras eu tellus eu augue porttitor",Category = "Food", PicturePath = "images/product.png"},
                new Product() {UPC = "837784", Code = "CVK883", ShortDescription = "ipsum. Donec", Description = "justo nec ante. Maecenas mi felis,",Category = "Drugs", PicturePath = "images/product.png"},
                new Product() {UPC = "169290", Code = "ZHM657", ShortDescription = "sem mollis dui,", Description = "sapien imperdiet ornare. In faucibus. Morbi",Category = "Clothing", PicturePath = "images/product.png"},
                new Product() {UPC = "621936", Code = "FCE463", ShortDescription = "et netus et malesuada", Description = "congue, elit sed consequat",Category = "Electronics", PicturePath = "images/product.png"},
                new Product() {UPC = "135049", Code = "TCM357", ShortDescription = "quis, tristique ac, eleifend", Description = "posuere cubilia Curae; Donec tincidunt.",Category = "Electronics", PicturePath = "images/product.png"},

            };
        }

        public IEnumerable<Product> GetAll()
        {
            foreach (Product p in products)
            {
                yield return p;
            }
        }
    }
}
