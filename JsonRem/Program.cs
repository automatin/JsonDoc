using DocJSON;
using System;
using Newtonsoft.Json;

namespace JsonRem
{
    class Program
    {
        static void Main(string[] args)
        {
            //JSON Example
            //{
            //    "menu": {
            //        "id": "file",
            //        "value": "File",
            //        "popup": {
            //            "menuitem": [
            //                {"value": "New", "onclick": "CreateNewDoc()"},
            //                {"value": "Open", "onclick": "OpenDoc()"},
            //                {"value": "Close", "onclick": "CloseDoc()"}
            //            ]
            //        }
            //    }
            //}

            /*
             * Si tenes un JSON copiado en el portapapeles (como el ejemplo anterior), podes ir a "Edit" ---> "Paste Special" y 
             * se crearan las clases necesarias para asociar ese JSON como se ve en la clase JsonObject que representa al JSON 
             * en formato de objetos c#...
             * 
            */

            //Objeto que representa el equivalente al Json Example
            JsonObject myJsonObject = new JsonObject()
            {
                menu = new JsonObject.Menu()
                {
                    id = "idX",
                    value = "UnValueX",
                    popup = new JsonObject.Popup()
                    {
                        menuitemArray = new JsonObject.Menuitem[] {
                            new JsonObject.Menuitem(){
                                value = "New",
                                onclick = "CreateNewDoc()"
                            },
                            new JsonObject.Menuitem(){
                                value = "Open",
                                onclick = "OpenDoc()"
                            },
                            new JsonObject.Menuitem(){
                                value = "Close",
                                onclick = "CloseDoc()"
                            }
                        }
                    }
                }
            };

            //Conversion de un Object a un Json
            string outputFormated = JsonConvert.SerializeObject(myJsonObject, Formatting.Indented);
            string outputWithoutFormat = JsonConvert.SerializeObject(myJsonObject);

            //Conversion Inversa...
            JsonObject toObjectAgain = JsonConvert.DeserializeObject<JsonObject>(outputFormated);

            Console.WriteLine(outputFormated);
            Console.ReadLine();
        }
    }
}
