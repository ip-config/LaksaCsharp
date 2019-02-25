﻿using LaksaCsharp.BlockChain;
using LaksaCsharp.Transaction;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LaksaCsharp.Jsonrpc
{
    public class HttpProvider
    {
        private string url;

        public HttpProvider(string url)
        {
            this.url = url;
        }

        public string GetNetworkId()
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetNetworkId";
            req.Params = new string[] { "" };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<string> rep = JsonConvert.DeserializeObject<Rep<string>>(response.Content);

            return rep.Result;
        }

        public BlockchainInfo GetBlockchainInfo()
        {

            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetBlockchainInfo";
            req.Params = new string[] { "" };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<BlockchainInfo> rep = JsonConvert.DeserializeObject<Rep<BlockchainInfo>>(response.Content);

            return rep.Result;
        }

        public Rep<ShardingStructure> GetShardingStructure()
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetShardingStructure";
            req.Params = new string[] { "" };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<ShardingStructure> rep = JsonConvert.DeserializeObject<Rep<ShardingStructure>>(response.Content);
            return rep;
        }


        public BlockList GetDSBlockListing(int pageNumber)
        {
            Req<int> req = new Req<int>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "DSBlockListing";
            req.Params = new int[] { pageNumber };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<BlockList> rep = JsonConvert.DeserializeObject<Rep<BlockList>>(response.Content);

            return rep.Result;
        }


        public BlockList GetTxBlockListing(int pageNumber)
        {
            Req<int> req = new Req<int>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "TxBlockListing";
            req.Params = new int[] { pageNumber };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<BlockList> rep = JsonConvert.DeserializeObject<Rep<BlockList>>(response.Content);

            return rep.Result;
        }


        public string GetNumDSBlocks()
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetNumDSBlocks";
            req.Params = new string[] { "" };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<string> rep = JsonConvert.DeserializeObject<Rep<string>>(response.Content);

            return rep.Result;
        }

        public double GetDSBlockRate()
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetDSBlockRate";
            req.Params = new string[] { "" };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<double> rep = JsonConvert.DeserializeObject<Rep<double>>(response.Content);

            return rep.Result;
        }

        public BlockList GetDSBlockListing()
        {
            Req<object> req = new Req<object>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "DSBlockListing";
            req.Params = new object[] { 1 };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<BlockList> rep = JsonConvert.DeserializeObject<Rep<BlockList>>(response.Content);

            return rep.Result;
        }

        public DsBlock GetDsBlock(string blockNumber)
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetDsBlock";
            req.Params = new string[] { blockNumber };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<DsBlock> rep = JsonConvert.DeserializeObject<Rep<DsBlock>>(response.Content);

            return rep.Result;
        }


        public TxBlock GetTxBlock(String blockNumber)
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetTxBlock";
            req.Params = new string[] { blockNumber };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<TxBlock> rep = JsonConvert.DeserializeObject<Rep<TxBlock>>(response.Content);

            return rep.Result;
        }

        public string GetNumTxBlocks()
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetNumTxBlocks";
            req.Params = new string[] { "" };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<string> rep = JsonConvert.DeserializeObject<Rep<string>>(response.Content);

            return rep.Result;
        }

        public double GetTxBlockRate()
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetTxBlockRate";
            req.Params = new string[] { "" };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<double> rep = JsonConvert.DeserializeObject<Rep<double>>(response.Content);

            return rep.Result;
        }


        public DsBlock GetLatestDsBlock()
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetBlockchainInfo";
            req.Params = new string[] { "" };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<DsBlock> rep = JsonConvert.DeserializeObject<Rep<DsBlock>>(response.Content);

            return rep.Result;
        }

        public string GetNumTransactions()
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetNumTransactions";
            req.Params = new string[] { "" };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);
            Rep<string> rep = JsonConvert.DeserializeObject<Rep<string>>(response.Content);

            return rep.Result;
        }

        public int GetTransactionRate()
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetTransactionRate";
            req.Params = new string[] { "" };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);
            Rep<int> rep = JsonConvert.DeserializeObject<Rep<int>>(response.Content);

            return rep.Result;
        }

        public string GetCurrentMiniEpoch()
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetCurrentMiniEpoch";
            req.Params = new string[] { "" };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);
            Rep<string> rep = JsonConvert.DeserializeObject<Rep<string>>(response.Content);

            return rep.Result;
        }

        public string GetCurrentDSEpoch()
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetCurrentDSEpoch";
            req.Params = new string[] { "" };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);
            Rep<string> rep = JsonConvert.DeserializeObject<Rep<string>>(response.Content);

            return rep.Result;
        }

        public int GetPrevDifficulty()
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetPrevDifficulty";
            req.Params = new string[] { "" };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);
            Rep<int> rep = JsonConvert.DeserializeObject<Rep<int>>(response.Content);

            return rep.Result;
        }

        public Rep<int?> GetPrevDSDifficulty()
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetPrevDSDifficulty";
            req.Params = new string[] { "" };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);
            Rep<int?> rep = JsonConvert.DeserializeObject<Rep<int?>>(response.Content);

            return rep;
        }

        public TxBlock GetLatestTxBlock()
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetLatestTxBlock";
            req.Params = new string[] { "" };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<TxBlock> rep = JsonConvert.DeserializeObject<Rep<TxBlock>>(response.Content);

            return rep.Result;
        }

        //Account-related methods
        public Rep<BalanceResult> GetBalance(string address)
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetBalance";
            req.Params = new string[] { address };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.JsonSerializer = new JsonSerialize();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);
            Rep<BalanceResult> rep = JsonConvert.DeserializeObject<Rep<BalanceResult>>(response.Content);

            return rep;
        }


        //Contract-related methods todo need test
        public string GetSmartContractCode(String address)
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetSmartContractCode";
            req.Params = new string[] { address };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<ContractResult> rep = JsonConvert.DeserializeObject<Rep<ContractResult>>(response.Content);

            return rep.Result.Code;
        }

        /*public List<Contract> GetSmartContracts(string address)
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetSmartContracts";
            req.Params = new string[] { address };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<List<Contract>> rep = JsonConvert.DeserializeObject<Rep<List<Contract>>>(response.Content);

            return rep.Result;
        }*/

        public Rep<string> GetContractAddressFromTransactionID(string address)
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetContractAddressFromTransactionID";
            req.Params = new string[] { address };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<string> rep = JsonConvert.DeserializeObject<Rep<string>>(response.Content);

            return rep;
        }


        /* public List<Contract.State> GetSmartContractState(String address)
         {
             Req<string> req = new Req<string>();
             req.Id = "1";
             req.Jsonrpc = "2.0";
             req.Method = "GetSmartContractState";
             req.Params = new string[] { address
        };

             RestClient client = new RestClient(url);
             RestRequest request = new RestRequest();
             request.AddJsonBody(req);
             IRestResponse response = client.Post(request);

             Rep<List<Contract.State>> rep = JsonConvert.DeserializeObject<Rep<List<Contract.State>>>(response.Content);

             return rep.Result;

         }*/

        /*public List<Contract.State> GetSmartContractInit(string address)
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetSmartContractInit";
            req.Params = new string[] { address
        };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<List<Contract.State>> rep = JsonConvert.DeserializeObject<Rep<List<Contract.State>>>(response.Content);

            return rep.Result;
        }*/

        //Transaction-related methods
        public CreateTxResult CreateTransaction(TransactionPayload payload)
        {
            Req<TransactionPayload> req = new Req<TransactionPayload>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "CreateTransaction";
            req.Params = new TransactionPayload[] { payload };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<CreateTxResult> rep = JsonConvert.DeserializeObject<Rep<CreateTxResult>>(response.Content);

            return rep.Result;

        }

        public string GetMinimumGasPrice()
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetMinimumGasPrice";
            req.Params = new string[] { "" };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<string> rep = JsonConvert.DeserializeObject<Rep<string>>(response.Content);

            return rep.Result;
        }


        public Transaction.Transaction GetTransaction(string hash)
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetTransaction";
            req.Params = new string[] { hash };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<Transaction.Transaction> rep = JsonConvert.DeserializeObject<Rep<Transaction.Transaction>>(response.Content);

            return rep.Result;
        }

        public TransactionList GetRecentTransactions()
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetRecentTransactions";
            req.Params = new string[] { "" };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<TransactionList> rep = JsonConvert.DeserializeObject<Rep<TransactionList>>(response.Content);

            return rep.Result;
        }

        public Rep<List<List<string>>> GetTransactionsForTxBlock(string blockNum)
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetTransactionsForTxBlock";
            req.Params = new string[] { blockNum };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<List<List<string>>> rep = JsonConvert.DeserializeObject<Rep<List<List<string>>>>(response.Content);

            return rep;
        }

        public Rep<string> GetNumTxnsTxEpoch()
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetNumTxnsTxEpoch";
            req.Params = new string[] { "" };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<string> rep = JsonConvert.DeserializeObject<Rep<string>>(response.Content);

            return rep;
        }

        public Rep<string> GetNumTxnsDSEpoch()
        {
            Req<string> req = new Req<string>();
            req.Id = "1";
            req.Jsonrpc = "2.0";
            req.Method = "GetNumTxnsDSEpoch";
            req.Params = new string[] { "" };

            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            request.AddJsonBody(req);
            IRestResponse response = client.Post(request);

            Rep<string> rep = JsonConvert.DeserializeObject<Rep<string>>(response.Content);

            return rep;
        }
    }

}

public class BalanceResult
{
    public string Balance { get; set; }
    public string Nonce { get; set; }
}

public class ContractResult
{
    public string Code { get; set; }
}

public class CreateTxResult
{
    public string Info { get; set; }
    public string TranID { get; set; }


    public override string ToString()
    {
        return "CreateTxResult{" +
                "Info='" + Info + '\'' +
                ", TranID='" + TranID + '\'' +
                '}';
    }
}
