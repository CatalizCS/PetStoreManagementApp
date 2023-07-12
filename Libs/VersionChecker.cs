using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace PetStoreManagementApp.Libs
{
    public class VersionChecker
    {
        private static VersionChecker instance;
        public static string githubURL = "https://github.com/CatalizCS/PetStoreManagementApp";


        public static VersionChecker Instance
        {
            get
            {
                if (instance == null)
                    instance = new VersionChecker();
                return instance;
            }
        }

        async Task<string> GetVersionFromGithub()
        {
            string version = "";
            HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            try
            {
                // create http request to get version from github
                string[] lines = (await client.GetStringAsync(githubURL + "/blob/master/VERSION")).Split('\n');
                version = lines[0];
            }
            catch
            {
                version = "0.0.0";
            }
            return version;
        }


        public async Task<bool> checkVersion()
        {
            string currentVersion = getVersion();
            string latestVersion = await GetVersionFromGithub();
            return versionCompare(currentVersion, latestVersion);
        }


        public string getVersion()
        {
            string version = "";
            try
            {
                string[] lines = System.IO.File.ReadAllLines("VERSION");
                version = lines[0];
            }
            catch
            {
                version = "0.0.1";
            }
            return version;
        }

        public bool versionCompare(string version1, string version2)
        {
            string[] version1Arr = version1.Split('.');
            string[] version2Arr = version2.Split('.');

            if (version1Arr.Length != version2Arr.Length)
                return false;

            for (int i = 0; i < version1Arr.Length; i++)
            {
                if (int.Parse(version1Arr[i]) < int.Parse(version2Arr[i]))
                    return false;
            }

            return true;
        }
    }
}
