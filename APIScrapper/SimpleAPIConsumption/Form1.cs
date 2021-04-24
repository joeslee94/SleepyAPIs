using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleAPIConsumption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetResult_Click(object sender, EventArgs e)
        {
            //debugOutPut("Test string for Button Functionality.");

            APIProcessor aProcessor = new APIProcessor();
            aProcessor.EndPointURI = textBoxEndpointInput.Text;

            string responseFromApi = aProcessor.GetRequest();
            textBoxResultJSONList.Text = responseFromApi; 
        }

        

        private void buttonDeserializeResults_Click(object sender, EventArgs e)
        {
            APIProcessor aProcessor = new APIProcessor();
            aProcessor.EndPointURI = textBoxEndpointInput.Text;
            string responseFromApi = aProcessor.GetRequest();

            try
            {
                var filmsResult = JsonConvert.DeserializeObject<FilmsResult>(responseFromApi);
                var films = filmsResult.results;
                //SimpleAPIConsumption.FilmsResult
                //textBoxDeserializedResults.Text += filmsResult.results.film.title;
                foreach (var film in films)
                {
                    textBoxDeserializedResults.Text += $"{film.title} {Environment.NewLine}";
                }
                //We had a problem Cannot deserialize the current JSON array(e.g. [1, 2, 3]) into type 'SimpleAPIConsumption.Film' because the type requires a JSON object(e.g. { "name":"value"}) to deserialize correctly.
                //To fix this error either change the JSON to a JSON object(e.g. { "name":"value"}) or change the deserialized type to an array or a type that implements a collection interface (e.g.ICollection, IList) like List<T> that can be deserialized from a JSON array.JsonArrayAttribute can also be added to the type to force it to deserialize from a JSON array.
                //Path 'results', line 1, position 50..
                //https://swapi.dev/api/films/
            }
            catch (Exception ex)
            {
                textBoxDeserializedResults.Text = $"We had a problem {ex.Message}.";
            }
        }

        private void buttonClearDeserializedResults_Click(object sender, EventArgs e)
        {
            textBoxResultJSONList.Clear();
            textBoxDeserializedResults.Clear();
        }

        //private string DeserializeJSON(string itemOfInterest, class<T> classOfInterest)
        private void debugOutPutForGetResults(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                textBoxResultJSONList.Text = textBoxResultJSONList.Text + strDebugText + Environment.NewLine;
                textBoxResultJSONList.SelectionStart = textBoxResultJSONList.TextLength;
                textBoxResultJSONList.ScrollToCaret();
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
    }
}
