using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CSharp;
using Newtonsoft.Json;
using OpenAI_API;
using OpenAI_API.Completions;
using WindowsGPT.Key;


namespace WindowsGPT
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true; // Para habilitar el autoscroll
            flowLayoutPanel1.HorizontalScroll.Enabled = false; // Para deshabilitar el scroll horizontal
            txtwriter.BorderStyle = BorderStyle.None;

        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            string apiKey = privateKey.Key;
            string prompt = txtwriter.Text;

            Dictionary<string, string> ejemplos = Jobs.SearchJson.LeerDiccionarioDesdeJSON();

            SendMessage(prompt);
            // Buscar si la solicitud coincide parcialmente con alguna clave de ejemplo
            bool solicitudEncontrada = false;
            foreach (var ejemplo in ejemplos)
            {
                if (prompt.Contains(ejemplo.Key))
                {
                    solicitudEncontrada = true;


                    // Componer el prompt completo
                    string prompt_complete = Jobs.PromptBuilder.GeneratePrompt(prompt, ejemplo.Value);
                    //string prompt_complete = promptBuilder.ToString();
                    try
                    {
                        var api = new OpenAI_API.OpenAIAPI(apiKey);
                        CompletionRequest completionRequest = new CompletionRequest();
                        completionRequest.Prompt = prompt_complete;
                        completionRequest.MaxTokens = 50;

                        var result = await api.Completions.CreateCompletionAsync(completionRequest);
                        //string respuestaGenerada = result.Choices[0].Text.Trim();
                        if (result.Completions.Count > 0)
                        {
                            // Accede a la primera completación en la lista
                            var completions = result.Completions[0];

                            // Ahora puedes acceder a las propiedades de la completación
                            string respuestaGenerada = completions.Text.Trim();
                            respuestaGenerada = respuestaGenerada.Replace("\r", "").Replace("\n", "");
                            // Mostrar la respuesta en la consola y en la interfaz de usuario
                            Console.WriteLine($"Respuesta generada: {respuestaGenerada}");
                            ReceiveMessage(respuestaGenerada);

                            Jobs.RunTask.run(respuestaGenerada);
                            // Limpiar el cuadro de texto
                            txtwriter.Clear();
                        }
                        else
                        {
                            // Manejar el caso en el que no se reciba ninguna completación
                            Console.WriteLine("No se recibió ninguna completación de la API.");
                        }
                        txtwriter.Clear();
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al llamar a la API: " + ex.Message);
                    }
                }
            }
            if (!solicitudEncontrada)
            {
                ReceiveMessage(txtwriter.Text);
                txtwriter.Clear();
            }
        }



        private void ReceiveMessage(string message)
        {
            Panel messagePanel = AddMessage("WindowsGPT", message, Color.DodgerBlue);
            flowLayoutPanel1.Controls.Add(messagePanel);
        }
        private void SendMessage(string message)
        {
            Panel messagePanel = AddMessage("Diego G.", message, Color.LightGreen);
            flowLayoutPanel1.Controls.Add(messagePanel);
        }

        private Panel AddMessage(string sender, string message, Color color)
        {
            Panel newMessage = new Panel();
            newMessage.BackColor = Envia.BackColor; // Puedes ajustar el color de fondo según sea necesario
            newMessage.BorderStyle = Envia.BorderStyle; // Puedes ajustar el estilo del borde según sea necesario
            newMessage.Width = Envia.Width;
            newMessage.Margin = Envia.Margin;
            newMessage.Dock = Envia.Dock;
            newMessage.Location = Envia.Location;
            newMessage.Anchor = Envia.Anchor;
            newMessage.AutoScroll = Envia.AutoScroll;
            newMessage.AutoSize = Envia.AutoSize;
            newMessage.Location = Envia.Location;
            newMessage.Size = Envia.Size;
            //Nombre
            Label senderLabel = new Label();
            senderLabel.Text = sender;
            senderLabel.Font = nombre_sms.Font;
            senderLabel.ForeColor = nombre_sms.ForeColor;
            senderLabel.AutoSize = nombre_sms.AutoSize;
            senderLabel.Margin = nombre_sms.Margin;
            senderLabel.Dock = nombre_sms.Dock;
            senderLabel.Location = nombre_sms.Location;
            senderLabel.BackColor = nombre_sms.BackColor;
            //Mensaje
            Label messageLabel = new Label();
            messageLabel.Text = message;
            messageLabel.Font = Mensaje_sms.Font;
            messageLabel.BackColor = color;
            messageLabel.ForeColor = Color.Black;
            messageLabel.AutoSize = Mensaje_sms.AutoSize;
            messageLabel.Margin = Mensaje_sms.Margin;
            messageLabel.Dock = Mensaje_sms.Dock;
            messageLabel.BorderStyle = Mensaje_sms.BorderStyle;
            messageLabel.Padding = Mensaje_sms.Padding;

            //Dinamico 
            if (sender == "WindowsGPT")
            {
                senderLabel.TextAlign = ContentAlignment.MiddleRight;
                messageLabel.Dock = DockStyle.Right;

            }
            newMessage.Controls.Add(messageLabel);
            newMessage.Controls.Add(senderLabel);

            return newMessage;
        }


    }
}
