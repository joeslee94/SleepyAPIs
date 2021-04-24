using Newtonsoft.Json;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobustAPIConsumption
{
    public partial class APIGetDeserializer : Form
    {
        public APIGetDeserializer()
        {
            InitializeComponent();
        }

        private void buttonGetRawJSON_Click(object sender, EventArgs e)
        {
            InitialAPIProcessor getRawJSON = new InitialAPIProcessor();
            getRawJSON.EndPointURI = textBoxEndPoint.Text;
            string rawJSON = getRawJSON.EndPointToRawJSON();
            textBoxSerializedJSON.Text = rawJSON;
        }

        private void buttonDeserializeJSON_Click(object sender, EventArgs e)
        {
            InitialAPIProcessor getRawJSON = new InitialAPIProcessor();
            getRawJSON.EndPointURI = textBoxEndPoint.Text;
            string rawJSON = getRawJSON.EndPointToRawJSON();

            //DeserializeRAWJSON(rawJSON);
            DeserializeNestedRAWJSON(rawJSON);
        }
        private void DeserializeRAWJSON(string rawJSON)
        {
            try
            {
                var itemsFromJSON = JsonConvert.DeserializeObject<dynamic>(rawJSON);
                textBoxDeserializedJSON.Text += itemsFromJSON;
            }
            catch (Exception ex)
            {
                textBoxDeserializedJSON.Text = $"Error Message: {ex.Message}.";
            }            
        }

        private void DeserializeNestedRAWJSON(string rawJSON)
        {
            try
            {
                var itemsFromJSON = JsonConvert.DeserializeObject<FilmsResult>(rawJSON);
                var items = itemsFromJSON.results;
                foreach (var item in items)
                {
                    textBoxDeserializedJSON.Text += $"{item.title} was created {item.created} and was modified {item.edited}.";
                    textBoxDeserializedJSON.Text += Environment.NewLine;
                    textBoxDeserializedJSON.Text += Environment.NewLine;

                }
            }
            catch (Exception ex)
            {
                textBoxDeserializedJSON.Text = $"Error Message: {ex.Message}.";
            }
        }

        private void buttonClearForm_Click(object sender, EventArgs e)
        {
            textBoxSerializedJSON.Clear();
            textBoxDeserializedJSON.Clear();
        }

        private void textBoxEndPoint_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSerializedJSON_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDeserializedJSON_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
