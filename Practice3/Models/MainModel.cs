using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Practice3.Tools;

namespace Practice3.Models
{
    [Serializable]
    class MainModel
    {

        private Storage _storage;

        public event Action<UserModel> UIUserAdded;

        public MainModel(Storage storage)
        {
            _storage = storage;
            storage.UserAdded += OnUserAdded;
        }

        private void OnUserAdded(UserModel userModel)
        {
            UIUserAdded?.Invoke(userModel);
        }

        public void DoMagic()
        {
            CreateDoVeryImportantWorkThread();
        }

        public async Task DoLongOperation()
        {
            await CreateDoVeryImportantWorkTaskAsync();
        }

        private void SerializeDeserializeBinary()
        {
            SerializeManager.SerializeBinary(_storage, "serializebinary.txt");
            var storage = SerializeManager.DeserializeBinary<Storage>("serializebinary.txt");
            Logger.Log("Storage was serialized and deserialized");
        }

        private void SerializeDeserializeXML()
        {
            var firstUser = _storage?.Users?.Values?.FirstOrDefault();
            if (firstUser != null)
            {
                SerializeManager.SerializeXML(firstUser, "serializeXML.txt");
                var deserializedFirstUser = SerializeManager.DeserializeXML<UserModel>("serializeXML.txt");
                Logger.Log("Storage was serialized and deserialized");
            }
        }

        private void SerializeDeserializeJSON()
        {
            SerializeManager.SerializeJSON(_storage, "serializeJSON.txt");
            var storage = SerializeManager.DeserializeJSON<Storage>("serializeJSON.txt");
            Logger.Log("Storage was serialized and deserialized");
        }

        private void CreateDoVeryImportantWorkThread()
        {
            Thread thread = new Thread(DoVeryImportantWork);
            thread.Start();
        }

        private void CreateDoVeryImportantWorkTask()
        {
            //Task.Factory.StartNew(DoVeryImportantWork);
            Task task = new Task(DoVeryImportantWork);
            task.Start();
        }

        private async Task CreateDoVeryImportantWorkTaskAsync()
        {
            //await Task.Factory.StartNew(DoVeryImportantWork);
            //Task task = new Task(DoVeryImportantWork);
            await Task.Run(() => DoVeryImportantWork());
            MessageBox.Show("I've done very important work!");
        }

        private void DoVeryImportantWork()
        {
            Thread.Sleep(5000);
            MessageBox.Show("Work finished!");
        }
    }
}
