using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace provide
{
    public class Goldmine: ApiClient
    {
        public Goldmine(string token) : base(token) {}

        public Goldmine InitGoldmine(string token) {
            return new Goldmine(token);
        }

        // CreateAccount
        public async Task<(int, object)> CreateAccount(Dictionary<string, object> args) {
            return await this.Post("accounts", args);
        }

        // ListAccounts
        public async Task<(int, object)> ListAccounts(Dictionary<string, object> args) {
            return await this.Get("accounts", args);
        }

        // GetAccountDetails
        public async Task<(int, object)> GetAccountDetails(string accountID, Dictionary<string, object> args) {
            var uri = String.Format("accounts/{0}", accountID);
            return await this.Get(uri, args);
        }

        // GetAccountBalance
        public async Task<(int, object)> GetAccountBalance(string accountID, string tokenID, Dictionary<string, object> args) {
            var uri = String.Format("accounts/{0}/balances/{1}", accountID, tokenID);
            return await this.Get(uri, args);
        }

        // CreateBridge
        public async Task<(int, object)> CreateBridge(Dictionary<string, object> args) {
            return await this.Post("bridges", args);
        }

        // ListBridges
        public async Task<(int, object)> ListBridges(Dictionary<string, object> args) {
            return await this.Get("bridges", args);
        }

        // GetBridgeDetails
        public async Task<(int, object)> GetBridgeDetails(string bridgeID, Dictionary<string, object> args) {
            var uri = String.Format("bridges/{0}", bridgeID);
            return await this.Get(uri, args);
        }

        // CreateConnector
        public async Task<(int, object)> CreateConnector(Dictionary<string, object> args) {
            return await this.Post("connectors", args);
        }

        // ListConnectors
        public async Task<(int, object)> ListConnectors(Dictionary<string, object> args) {
            return await this.Get("connectors", args);
        }

        // GetConnectorDetails
        public async Task<(int, object)> GetConnectorDetails(string connectorID, Dictionary<string, object> args) {
            var uri = String.Format("connectors/{0}", connectorID);
            return await this.Get(uri, args);
        }

        // DeleteConnector
        public async Task<(int, object)> DeleteConnector(string connectorID) {
            var uri = String.Format("connectors/{0}", connectorID);
            return await this.Delete(uri);
        }

        // ListConnectedEntities -- invokes the configured connector proxy in a RESTful manner -- i.e., GET /
        public async Task<(int, object)> ListConnectedEntities(string connectorID, Dictionary<string, object> args) {
            var uri = String.Format("connectors/{0}/entities", connectorID);
            return await this.Get(uri, args);
        }

        // GetConnectedEntityDetails -- invokes the configured connector proxy in a RESTful manner -- i.e., GET /:id
        public async Task<(int, object)> GetConnectedEntityDetails(string connectorID, string entityID, Dictionary<string, object> args) {
            var uri = String.Format("connectors/{0}/entities/{1}", connectorID, entityID);
            return await this.Get(uri, args);
        }

        // CreateConnectedEntity -- invokes the configured connector proxy in a RESTful manner -- i.e., POST /
        public async Task<(int, object)> CreateConnectedEntity(string connectorID, Dictionary<string, object> args) {
            var uri = String.Format("connectors/{0}/entities", connectorID);
            return await this.Post(uri, args);
        }

        // UpdateConnectedEntity -- invokes the configured connector proxy in a RESTful manner -- i.e., PUT /:id
        public async Task<(int, object)> UpdateConnectedEntity(string connectorID, string entityID, Dictionary<string, object> args) {
            var uri = String.Format("connectors/{0}/entities/{1}", connectorID, entityID);
            return await this.Put(uri, args);
        }

        // DeleteConnectedEntity -- invokes the configured connector proxy in a RESTful manner -- i.e., DELETE /:id
        public async Task<(int, object)> DeleteConnectedEntity(string connectorID, string entityID) {
            var uri = String.Format("connectors/{0}/entities/{1}", connectorID, entityID);
            return await this.Delete(uri);
        }

        // CreateContract
        public async Task<(int, object)> CreateContract(Dictionary<string, object> args) {
            return await this.Post("contracts", args);
        }

        // ExecuteContract
        public async Task<(int, object)> ExecuteContract(string contractID, Dictionary<string, object> args) {
            var uri = String.Format("contracts/{0}/execute", contractID);
            return await this.Post(uri, args);
        }

        // ListContracts
        public async Task<(int, object)> ListContracts(Dictionary<string, object> args) {
            return await this.Get("contracts", args);
        }

        // GetContractDetails
        public async Task<(int, object)> GetContractDetails(string contractID, Dictionary<string, object> args) {
            var uri = String.Format("contracts/{0}", contractID);
            return await this.Get(uri, args);
        }

        // CreateNetwork
        public async Task<(int, object)> CreateNetwork(Dictionary<string, object> args) {
            return await this.Post("networks", args);
        }

        // UpdateNetwork updates an existing network
        public async Task<(int, object)> UpdateNetwork(string networkID, Dictionary<string, object> args) {
            var uri = String.Format("networks/{0}", networkID);
            return await this.Put(uri, args);
        }

        // ListNetworks
        public async Task<(int, object)> ListNetworks(Dictionary<string, object> args) {
            return await this.Get("networks", args);
        }

        // GetNetworkDetails
        public async Task<(int, object)> GetNetworkDetails(string networkID, Dictionary<string, object> args) {
            var uri = String.Format("networks/{0}", networkID);
            return await this.Get(uri, args);
        }

        // ListNetworkAccounts
        public async Task<(int, object)> ListNetworkAccounts(string networkID, Dictionary<string, object> args) {
            var uri = String.Format("networks/{0}/accounts", networkID);
            return await this.Get(uri, args);
        }

        // ListNetworkBlocks
        public async Task<(int, object)> ListNetworkBlocks(string networkID, Dictionary<string, object> args) {
            var uri = String.Format("networks/{0}/blocks", networkID);
            return await this.Get(uri, args);
        }

        // ListNetworkBridges
        public async Task<(int, object)> ListNetworkBridges(string networkID, Dictionary<string, object> args) {
            var uri = String.Format("networks/{0}/bridges", networkID);
            return await this.Get(uri, args);
        }

        // ListNetworkConnectors
        public async Task<(int, object)> ListNetworkConnectors(string networkID, Dictionary<string, object> args) {
            var uri = String.Format("networks/{0}/connectors", networkID);
            return await this.Get(uri, args);
        }

        // ListNetworkContracts
        public async Task<(int, object)> ListNetworkContracts(string networkID, Dictionary<string, object> args) {
            var uri = String.Format("networks/{0}/contracts", networkID);
            return await this.Get(uri, args);
        }

        // GetNetworkContractDetails
        public async Task<(int, object)> GetNetworkContractDetails(string networkID, string contractID, Dictionary<string, object> args) {
            var uri = String.Format("networks/{0}/contracts/{1}", networkID, contractID);
            return await this.Get(uri, args);
        }

        // ListNetworkOracles
        public async Task<(int, object)> ListNetworkOracles(string networkID, Dictionary<string, object> args) {
            var uri = String.Format("networks/{0}/oracles", networkID);
            return await this.Get(uri, args);
        }

        // ListNetworkTokens
        public async Task<(int, object)> ListNetworkTokens(string networkID, Dictionary<string, object> args) {
            var uri = String.Format("networks/{0}/tokens", networkID);
            return await this.Get(uri, args);
        }

        // ListNetworkTransactions
        public async Task<(int, object)> ListNetworkTransactions(string networkID, Dictionary<string, object> args) {
            var uri = String.Format("networks/{0}/transactions", networkID);
            return await this.Get(uri, args);
        }

        // GetNetworkTransactionDetails
        public async Task<(int, object)> GetNetworkTransactionDetails(string networkID, string txID, Dictionary<string, object> args) {
            var uri = String.Format("networks/{0}/transactions/{1}", networkID, txID);
            return await this.Get(uri, args);
        }

        // GetNetworkStatusMeta
        public async Task<(int, object)> GetNetworkStatusMeta(string networkID, string txID, Dictionary<string, object> args) {
            var uri = String.Format("networks/{0}/status", networkID, txID);
            return await this.Get(uri, args);
        }

        // ListNetworkNodes
        public async Task<(int, object)> ListNetworkNodes(string networkID, Dictionary<string, object> args) {
            var uri = String.Format("networks/{0}/nodes", networkID);
            return await this.Get(uri, args);
        }

        // CreateNetworkNode
        public async Task<(int, object)> CreateNetworkNode(string networkID, Dictionary<string, object> args) {
            var uri = String.Format("networks/{0}/nodes", networkID);
            return await this.Post(uri, args);
        }

        // GetNetworkNodeDetails
        public async Task<(int, object)> GetNetworkNodeDetails(string networkID, string nodeID, Dictionary<string, object> args) {
            var uri = String.Format("networks/{0}/nodes/{1}", networkID, nodeID);
            return await this.Get(uri, args);
        }

        // GetNetworkNodeLogs
        public async Task<(int, object)> GetNetworkNodeLogs(string networkID, string nodeID, Dictionary<string, object> args) {
            var uri = String.Format("networks/{0}/nodes/{1}/logs", networkID, nodeID);
            return await this.Get(uri, args);
        }

        // DeleteNetworkNode
        public async Task<(int, object)> DeleteNetworkNode(string networkID, string nodeID) {
            var uri = String.Format("networks/{0}/nodes/{1}", networkID, nodeID);
            return await this.Delete(uri);
        }

        // CreateOracle
        public async Task<(int, object)> CreateOracle(Dictionary<string, object> args) {
            return await this.Post("oracles", args);
        }

        // ListOracles
        public async Task<(int, object)> ListOracles(Dictionary<string, object> args) {
            return await this.Get("oracles", args);
        }

        // GetOracleDetails
        public async Task<(int, object)> GetOracleDetails(string oracleID, Dictionary<string, object> args) {
            var uri = String.Format("oracles/{0}", oracleID);
            return await this.Get(uri, args);
        }

        // CreateTokenContract
        public async Task<(int, object)> CreateTokenContract(Dictionary<string, object> args) {
            return await this.Post("tokens", args);
        }

        // ListTokenContracts
        public async Task<(int, object)> ListTokenContracts(Dictionary<string, object> args) {
            return await this.Get("tokens", args);
        }

        // GetTokenContractDetails
        public async Task<(int, object)> GetTokenContractDetails(string tokenID, Dictionary<string, object> args) {
            var uri = String.Format("tokens/{0}", tokenID);
            return await this.Get(uri, args);
        }

        // CreateTransaction
        public async Task<(int, object)> CreateTransaction(Dictionary<string, object> args) {
            return await this.Post("transactions", args);
        }

        // ListTransactions
        public async Task<(int, object)> ListTransactions(Dictionary<string, object> args) {
            return await this.Get("transactions", args);
        }

        // GetTransactionDetails
        public async Task<(int, object)> GetTransactionDetails(string txID, Dictionary<string, object> args) {
            var uri = String.Format("transactions/{0}", txID);
            return await this.Get(uri, args);
        }

        // CreateWallet
        public async Task<(int, object)> CreateWallet(Dictionary<string, object> args) {
            return await this.Post("wallets", args);
        }

        // ListWallets
        public async Task<(int, object)> ListWallets(Dictionary<string, object> args) {
            return await this.Get("wallets", args);
        }

        // ListWalletAccounts
        public async Task<(int, object)> ListWalletAccounts(string walletID, Dictionary<string, object> args) {
            var uri = String.Format("wallets/{0}/accounts", walletID);
            return await this.Get(uri, args);
        }

        // GetWalletDetails
        public async Task<(int, object)> GetWalletDetails(string walletID, Dictionary<string, object> args) {
            var uri = String.Format("wallets/{0}", walletID);
            return await this.Get(uri, args);
        }
    }
}
