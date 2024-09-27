using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsGPT.Jobs
{
    class RunTask
    {
        public static void run(string @codigoCSharp)
        {
            try
            {
                string template = @"
                            using System;
                            using System.IO;
                            using System.Diagnostics;
                            using System.Collections.Generic;
                            using System.Drawing;

                            class class_Ejecutar
                            {
                                public static Dictionary<string, object> Ejecutar()
                                {
                                    Dictionary<string, object> resultado = new Dictionary<string, object>();
                                    try
                                    {
                                        " + @codigoCSharp + @"

                                        resultado[""Estado""] = true; 
                                        resultado[""Respuesta""] = ""OK""; // Mensaje de éxito

                                        return resultado;
                                    }
                                    catch (Exception e)
                                    {
                                        string errorMessage = e.Message;
                                        string stackTrace = e.StackTrace ?? ""No se pudo obtener la pila de llamadas."";
                                        string methodName = e.TargetSite != null ? e.TargetSite.Name : ""Método desconocido"";
                                        int lineNumber = 0;
                                        var stackFrames = new StackTrace(e, true).GetFrames();
                                        if (stackFrames != null && stackFrames.Length > 0)
                                        {
                                            lineNumber = stackFrames[0].GetFileLineNumber();
                                        }
                                        string detailedMessage = ""Error: "" + errorMessage + ""\nStackTrace: "" + stackTrace + ""\nEn el método: "" + methodName + "", Línea: "" + lineNumber;
                                        resultado[""Estado""] = false;
                                        resultado[""Respuesta""] = detailedMessage.ToString();
                                        return resultado;
                                    }
                                }
                            }";



                if (string.IsNullOrEmpty(codigoCSharp))
                {
                    return;
                }

                // Crea un proveedor de compilación de C#
                CSharpCodeProvider provider = new CSharpCodeProvider();
                CompilerParameters parameters = new CompilerParameters();

                parameters.ReferencedAssemblies.Add("System.dll");
                parameters.ReferencedAssemblies.Add("System.Data.dll");
                parameters.ReferencedAssemblies.Add("System.Collections.dll");
                parameters.ReferencedAssemblies.Add("System.Drawing.dll");
                //parameters.ReferencedAssemblies.Add("System.Data.OleDb.dll");

                parameters.GenerateInMemory = true;

                // Compila el código C#
                CompilerResults results = provider.CompileAssemblyFromSource(parameters, template);

                string Error = "";
                // Verifica si hubo errores de compilación
                if (results.Errors.HasErrors)
                {

                    foreach (CompilerError error in results.Errors)
                    {
                        // Escribir los datos en el archivo
                        Error += "Error en línea " + "{" + error.Line.ToString() + "}:{" + error.ErrorText.ToString() + "}";
                    }
                    // Acceder al TextBox "consola" a través de la propiedad pública en Dashboard
                    MessageBox.Show(Error);
                }
                else
                {

                    Type ejecutarTareaFinal1 = results.CompiledAssembly.GetType("class_Ejecutar");
                    Dictionary<string, object> respuesta;
                    object[] parametros = null;


                    respuesta = (Dictionary<string, object>)ejecutarTareaFinal1.GetMethod("Ejecutar").Invoke(null, parametros);
                    //Aqui verificamos que no existan errores de ejecucion
                    //Type tipoClassEjecutar = results.CompiledAssembly.GetType("class_Ejecutar");


                    //Si la respuesta de Estado es True
                    if ((bool)respuesta["Estado"])
                    {
                        MessageBox.Show(respuesta["Respuesta"].ToString());
                    }
                    else //Si la respuesta de Estado es False
                    {
                        MessageBox.Show("Error: ", respuesta["Respuesta"].ToString());
                    }

                }
                // Agregamos una pausa para que el hilo no consuma demasiados recursos
                Thread.Sleep(1000); // Pausa de 1 segundo
            }

            catch (Exception ex)
            {
                //SendMessage(ex.Message.ToString());
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
