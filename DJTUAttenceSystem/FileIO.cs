using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace DJTUAttenceSystem {
    class FileSerializeIO {
        protected static FileStream stream = null;
        protected static BinaryFormatter serializer = new BinaryFormatter();
    }
    class FileSerializeStorage<T> : FileSerializeIO where T : class {
        private FileSerializeStorage() { }
        public static void save(T obj,string path) {
            try {
                stream = new FileStream(path, FileMode.Create);
                serializer.Serialize(stream, obj);
                stream.Close();
            }catch(UnauthorizedAccessException e) {
                Console.WriteLine(e.Message);
                throw new FileSaveException("文件没有访问权限");
            } catch {
                throw new FileSaveException("文件存储失败，请重试");
            }
        }

        public class FileSaveException : ApplicationException {
            public FileSaveException(string message) : base(message) {

            }
        }
    }
    class FileSerilizeOpener<T>  : FileSerializeIO where T : class {
        private FileSerilizeOpener() { }
        public static T open(string path) {
            try {
                stream = new FileStream(path, FileMode.Open);
                T obj = serializer.Deserialize(stream) as T;
                stream.Close();
                return obj;
            }catch(FileNotFoundException) {
                throw new FileOpenException("未找到文件");
            }catch {
                throw new FileOpenException("序列化错误");
            }
        }

        public class FileOpenException : ApplicationException {
            public FileOpenException(string message) : base(message) {

            }
        }
    }
}
