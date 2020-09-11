using LINEBlockchainSDK.API.V1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINE_Blockchain_SDK_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public string service_api_key = "";
        public string service_api_secret = "";
        public string serviceId = "";
        public string contractId = "";
        public string Owner_wallet_Address = "";
        public string Owner_wallet_Secret = "";

        public void ListAllServiceTokensTest()
        {
            APIManager api = new APIManager(NetworkType.Cashew, service_api_key, service_api_secret);
            var result = api.ListAllServiceTokens();

        }

        public void RetrieveServiceInformationTest()
        {
            APIManager api = new APIManager(NetworkType.Cashew, service_api_key, service_api_secret);
            var result = api.RetrieveServiceInformation(serviceId);
        }

        public void RetrieveServiceTokenInformationTest()
        {
            APIManager api = new APIManager(NetworkType.Cashew, service_api_key, service_api_secret);
            var result = api.RetrieveServiceTokenInformation(contractId);
        }

        public void MintAServiceTokenTest()
        {
            APIManager api = new APIManager(NetworkType.Cashew, service_api_key, service_api_secret);
            var result = api.MintAServiceToken(contractId, new ToWalletAddress_Mint_Body()
            {
                toAddress = Owner_wallet_Address,
                amount = "1234567",
                ownerAddress = Owner_wallet_Address,
                ownerSecret = Owner_wallet_Secret
            });


        }

        public void ListAllServiceTokenHoldersTest()
        {
            APIManager api = new APIManager(NetworkType.Cashew, service_api_key, service_api_secret);
            var result = api.ListAllServiceTokenHolders(contractId, 1, 0, OrderBy.asc);
        }

        public void UpdateServiceTokenInformationTest()
        {
            APIManager api = new APIManager(NetworkType.Cashew, service_api_key, service_api_secret);
            var result = api.UpdateServiceTokenInformation(contractId, new UpdateServiceTokenInformation_Body()
            {
                ownerAddress = Owner_wallet_Address,
                ownerSecret = Owner_wallet_Secret,
                name = "test"
            });
        }

        public void BurnAServiceTokenTest()
        {
            APIManager api = new APIManager(NetworkType.Cashew, service_api_key, service_api_secret);
            var result = api.BurnAServiceToken(contractId, new BurnAServiceToken_Body()
            {
                ownerAddress = Owner_wallet_Address,
                ownerSecret = Owner_wallet_Secret,
                amount = "1000"
            });
        }

    }
}
