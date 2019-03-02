using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Xml_Basic_Homework_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "Tom",
                Surname = "Soer",
                age = 20,
                Specialty = "Рrogramming",
                studyСourse = 2,
                averageMark = 11.9
            };

            XmlDocument xmlDocument = new XmlDocument();
            var rootElement = xmlDocument.CreateElement("student");


            var nameElement = xmlDocument.CreateElement("name");
            nameElement.InnerText = student.Name;
            rootElement.AppendChild(nameElement);

            var surnameElement = xmlDocument.CreateElement("surname");
            surnameElement.InnerText = student.Surname;
            rootElement.AppendChild(surnameElement);

            var ageElement = xmlDocument.CreateElement("age");
            ageElement.InnerText = student.age.ToString();
            rootElement.AppendChild(ageElement);

            var specialtyElement = xmlDocument.CreateElement("specialty");
            specialtyElement.InnerText = student.Specialty;
            rootElement.AppendChild(specialtyElement);

            var studyCourseElement = xmlDocument.CreateElement("studyCourse");
            studyCourseElement.InnerText = student.studyСourse.ToString();
            rootElement.AppendChild(studyCourseElement);

            var averageMarkElement = xmlDocument.CreateElement("averageMark");
            averageMarkElement.InnerText = student.averageMark.ToString();
            rootElement.AppendChild(averageMarkElement);

            xmlDocument.AppendChild(rootElement);
            xmlDocument.Save("student.txt");
        }
    }
}
