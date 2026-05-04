using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TODOApp
{
    internal class JSONHandler
    {
        public JObject AddTask(JObject json, int id, Task newTask)
        {
            // Add the new task to the JSON object
            json.Add(id.ToString(), JObject.FromObject(newTask));

            // Update the JSON file with the new JSON object
            string jsonstr = json.ToString();
            string fileName = "tasks.json";
            File.WriteAllText(fileName, jsonstr);

            return json;
        }


        public JObject RemoveTask(JObject json, int taskId)
        {
            // Remove task 
            if (json.Remove(taskId.ToString()))
            {
                // Update ids
                int id = 0;
                foreach (var property in json.Properties().ToList())
                {
                    property.Replace(new JProperty(id.ToString(), property.Value));
                    id++;
                }

                // Update JSON file
                string jsonstr = json.ToString();
                string fileName = "tasks.json";
                File.WriteAllText(fileName, jsonstr);
            }
            else
            {
                MessageBox.Show("Task was not removed.");
            }

            return json;
        }


        public JObject EditTask(JObject oldJson, int taskId, Task updatedTask)
        {
            JObject newJson = new JObject();

            // TODO: Edit the task with the given taskId in the old JSON object using the information from updatedTask and return the updated JSON object

            return newJson;
        }
    }
    
}
