using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text.Json;
using UI.Enums;
using UI.Http_Client;
using System.ComponentModel.DataAnnotations;
using Http_Client;

namespace UI.Http_Client
{
    public class Service
    {
        private HttpClient _httpClient;
        string BaseUrl = "https://localhost:7082/api/Task";
        public Service()
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri(BaseUrl) };
        }

        public async Task<List<TaskItem>> GetAllTasks()
        {
            try
            {
                var response = await _httpClient.GetAsync("");

                if (response == null) return new List<TaskItem>(); ;

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    // Настраиваем параметры десериализации
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true // Игнорируем регистр имён свойств
                    };

                    var tasks = Newtonsoft.Json.JsonConvert.DeserializeObject<List<TaskItem>>(jsonResponse);
                    return tasks;
                }
                else
                {
                    MessageBox.Show(response.StatusCode.ToString());
                    return new List<TaskItem>();
                }
            }
            catch
            {
                MessageBox.Show("Connection Error");

                return new List<TaskItem>();
            }
           
        }

        public async Task<TaskItem> GetTask(int id)
        {
            var response = await _httpClient.GetAsync($"{BaseUrl}/{id}");
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                try
                {
                    var task = Newtonsoft.Json.JsonConvert.DeserializeObject<TaskItem>(jsonResponse);
                    return task;
                }
                catch (JsonException ex)
                {
                    throw new Exception("Failed to deserialize response body.", ex);
                }
            }
            else
            {
                string errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception($"Failed to retrieve task. Status code: {response.StatusCode}. Response: {errorResponse}");
            }
        }

        public async Task DeleteTask(int id)
        {
            var response = await _httpClient.DeleteAsync($"{BaseUrl}/{id}");
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Task {id} was deleted");
            }
            else {  MessageBox.Show(response.StatusCode.ToString());}
        }

        public async Task<bool> AddTaskAsync(TaskDto task)
        {
            var jsonContent = new StringContent(
                 System.Text.Json.JsonSerializer.Serialize(task),
                 Encoding.UTF8,
                 "application/json"
            );

            var responce = await _httpClient.PostAsync($"{BaseUrl}", jsonContent);
            if (responce.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                MessageBox.Show(responce.StatusCode.ToString());
                return false;
            }
        }

        public async Task UpdateTaskAsync(int taskId, TaskDto updatedTask)
        {
            var jsonContent = new StringContent(
                System.Text.Json.JsonSerializer.Serialize(updatedTask),
                Encoding.UTF8,
                "application/json"
            );

            var response = await _httpClient.PutAsync($"{BaseUrl}/{taskId}", jsonContent);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Task updated successfully.");
                var responseBody = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Response from server:");
                MessageBox.Show(responseBody);
            }
            else
            {
                MessageBox.Show($"Failed to update task. Status code: {response.StatusCode}");
                var errorDetails = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Error details: {errorDetails}");
            }
        }

    }
}
