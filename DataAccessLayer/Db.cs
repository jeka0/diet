using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using BusinessLayer;
using System.Xml.Serialization;

namespace DataAccessLayer
{
    public class Db: IModel
    {
        public static String standardFile { get; set; }
        private Categories categories;
        private Categories mealTimes;
        public Categories Categories { get { return categories; } }
        public Categories MealTimes { get { return mealTimes; } }
        public Db(String file)
        {
            if (Db.standardFile == null) standardFile = "Products.xml"; else standardFile = file;
            mealTimes = new Categories();
            ReadXml(standardFile);
        }
        private void ReadXml(String file)
        {
            if (File.Exists(file))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Categories));
                using (FileStream fs = new FileStream(file, FileMode.Open))
                {
                    categories = (Categories)formatter.Deserialize(fs);
                }
            }
            else { categories = new Categories(); categories.categories = new List<Category>(); }
        }
        public void SaveInXml(Categories categories, String file)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Categories));
            using (FileStream fs = new FileStream(file, FileMode.Create))
            {
                formatter.Serialize(fs, categories);
            }
        }
    }
}
