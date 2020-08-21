using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using GTF_Comm;
using GTF_STFM.Util;
using System.Windows.Forms;

namespace GTF_STFM.Tran
{
    //거래실행. 필요시 로컬 DB 정보 업데이트
    class Transaction
    {
        public string ServerUrl     { get; set; }
        public string ServerIp      { get; set; }
        public string ServerPort    { get; set; }

        public Transaction()
        {
            IgnoreBadCertificates();
        }

        public string Login(String strUserId , String strPassword)
        {
            string strReq = string.Empty;
            string strRes = string.Empty;

            try
            {
                GTF_CommManager comm = new GTF_CommManager(null);

                ServerUrl = Constants.SERVER_URL + "/service/merchant/tfm/login";

                JObject jsonReq = new JObject();
                JObject jsonRes = null;

                jsonReq.Add("userid", strUserId);
                jsonReq.Add("password", strPassword);
                
                strRes = comm.sendHttp_Json(ServerUrl, jsonReq.ToString(), true, Constants.SERVER_TIMEOUT);

                jsonRes = JObject.Parse(strRes);
                strRes = jsonRes["code"].ToString();

                if(jsonRes["group_id"] != null)
                {
                    Constants.GROUP_ID = jsonRes["group_id"].ToString();
                    Constants.GROUP_NAME = jsonRes["group_name"].ToString();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
            }

            return strRes;
        }

        //가맹점 검색
        public string searchStoreName(String strKeyword)
        {
            string strReq = string.Empty;
            string strRes = string.Empty;

            try
            {
                GTF_CommManager comm = new GTF_CommManager(null);

                ServerUrl = Constants.SERVER_URL + "/service/merchant/tfm/searchStoreName";

                JObject jsonReq = new JObject();
                JObject jsonRes = null;

                jsonReq.Add("keyword", strKeyword);
                jsonReq.Add("group_id", Constants.GROUP_ID);

                Constants.LOGGER_DOC.Info("-->" + jsonReq.ToString());
                strRes = comm.sendHttp_Json(ServerUrl, jsonReq.ToString(), true, Constants.SERVER_TIMEOUT);
                Constants.LOGGER_DOC.Info("<--" + strRes);

                jsonRes = JObject.Parse(strRes);
                strRes = jsonRes["list"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
            }

            return strRes;
        }

        //자동완성 가맹점 검색
        public string searchAutoCompanyName(String strKeyword)
        {
            string strReq = string.Empty;
            string strRes = string.Empty;

            try
            {
                GTF_CommManager comm = new GTF_CommManager(null);

                ServerUrl = Constants.SERVER_URL + "/service/merchant/tfm/searchAutoCompanyName";

                JObject jsonReq = new JObject();
                JObject jsonRes = null;

                jsonReq.Add("keyword", strKeyword);
                jsonReq.Add("group_id", Constants.GROUP_ID);

                Constants.LOGGER_DOC.Info("-->" + jsonReq.ToString());
                strRes = comm.sendHttp_Json(ServerUrl, jsonReq.ToString(), true, Constants.SERVER_TIMEOUT);
                Constants.LOGGER_DOC.Info("<--" + strRes);

                jsonRes = JObject.Parse(strRes);
                strRes = jsonRes["list"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
            }

            return strRes;
        }

        //자동완성 국가코드
        public string searchCountryCode(String strKeyword)
        {
            string strReq = string.Empty;
            string strRes = string.Empty;

            try
            {
                GTF_CommManager comm = new GTF_CommManager(null);

                ServerUrl = Constants.SERVER_URL + "/service/merchant/tfm/searchCountryCode";

                JObject jsonReq = new JObject();
                JObject jsonRes = null;

                Constants.LOGGER_DOC.Info("-->" + jsonReq.ToString());
                strRes = comm.sendHttp_Json(ServerUrl, jsonReq.ToString(), true, Constants.SERVER_TIMEOUT);
                Constants.LOGGER_DOC.Info("<--" + strRes);

                jsonRes = JObject.Parse(strRes);
                strRes = jsonRes["list"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
            }

            return strRes;
        }

        //Purchase Item List
        public string getItemCodeList()
        {
            string strReq = string.Empty;
            string strRes = string.Empty;

            try
            {
                GTF_CommManager comm = new GTF_CommManager(null);

                ServerUrl = Constants.SERVER_URL + "/service/merchant/tfm/getItemCodeList";

                JObject jsonReq = new JObject();
                JObject jsonRes = null;

                Constants.LOGGER_DOC.Info("-->" + jsonReq.ToString());
                strRes = comm.sendHttp_Json(ServerUrl, jsonReq.ToString(), true, Constants.SERVER_TIMEOUT);
                Constants.LOGGER_DOC.Info("<--" + strRes);

                jsonRes = JObject.Parse(strRes);
                strRes = jsonRes["list"].ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
            }
            return strRes;
        }

        public string issueTicket(string jsonReq)
        {
            string strRes = string.Empty;

            try
            {
                GTF_CommManager comm = new GTF_CommManager(null);

                ServerUrl = Constants.SERVER_URL + "/service/json/etrs/issueTicket";

                Constants.LOGGER_DOC.Info("-->" + jsonReq.ToString());
                strRes = comm.sendHttp_Json(ServerUrl, jsonReq.ToString(), true, Constants.SERVER_TIMEOUT);
                Constants.LOGGER_DOC.Info("<--" + strRes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
            }
            return strRes;
        }

        public string voidTicket(string jsonReq)
        {
            string strRes = string.Empty;

            try
            {
                GTF_CommManager comm = new GTF_CommManager(null);

                ServerUrl = Constants.SERVER_URL + "/service/json/etrs/voidTicket";

                Constants.LOGGER_DOC.Info("-->" + jsonReq.ToString());
                strRes = comm.sendHttp_Json(ServerUrl, jsonReq.ToString(), true, Constants.SERVER_TIMEOUT);
                Constants.LOGGER_DOC.Info("<--" + strRes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
            }
            return strRes;
        }

        // 2017년 9월 5일 전표번호 중복 체크 조회 
        public int checkRctCount(string jsonReq)
        {
            int nRctCnt = 0;           

            string strRes = string.Empty;

            try
            {
                GTF_CommManager comm = new GTF_CommManager(null);

                ServerUrl = Constants.SERVER_URL + "/service/merchant/tfm/checkRctCount";

                JObject jsonRes = null;

                Constants.LOGGER_DOC.Info("-->" + jsonReq.ToString());
                strRes = comm.sendHttp_Json(ServerUrl, jsonReq.ToString(), true, Constants.SERVER_TIMEOUT);
                Constants.LOGGER_DOC.Info("<--" + strRes);

                jsonRes = JObject.Parse(strRes);
                if (jsonRes["code"].ToString().Equals("1"))
                {
                    nRctCnt = int.Parse(jsonRes["total_cnt"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
            }

            return nRctCnt;
        }

        public int searchDocIdCount(string jsonReq)
        {
            int total_cnt = 0;

            string strRes = string.Empty;

            try
            {
                GTF_CommManager comm = new GTF_CommManager(null);

                ServerUrl = Constants.SERVER_URL + "/service/merchant/tfm/searchDocIdCount";

                JObject jsonRes = null;

                Constants.LOGGER_DOC.Info("-->" + jsonReq.ToString());
                strRes = comm.sendHttp_Json(ServerUrl, jsonReq.ToString(), true, Constants.SERVER_TIMEOUT);
                Constants.LOGGER_DOC.Info("<--" + strRes);

                jsonRes = JObject.Parse(strRes);
                if (jsonRes["code"].ToString().Equals("1"))
                {
                    total_cnt = int.Parse(jsonRes["total_cnt"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
            }

            return total_cnt;
        }

        public string searchDocIdList(string jsonReq)
        {
            string strRes = string.Empty;

            try
            {
                GTF_CommManager comm = new GTF_CommManager(null);

                ServerUrl = Constants.SERVER_URL + "/service/merchant/tfm/searchDocIdList";

                JObject jsonRes = null;

                Constants.LOGGER_DOC.Info("-->" + jsonReq.ToString());
                strRes = comm.sendHttp_Json(ServerUrl, jsonReq.ToString(), true, Constants.SERVER_TIMEOUT);
                Constants.LOGGER_DOC.Info("<--" + strRes);

                jsonRes = JObject.Parse(strRes);
                strRes = jsonRes["list"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
            }

            return strRes;
        }

        public int searchReceiptCount(string jsonReq)
        {
            int total_cnt = 0;

            string strRes = string.Empty;

            try
            {
                GTF_CommManager comm = new GTF_CommManager(null);

                ServerUrl = Constants.SERVER_URL + "/service/merchant/tfm/searchReceiptCount";

                JObject jsonRes = null;

                Constants.LOGGER_DOC.Info("-->" + jsonReq.ToString());
                strRes = comm.sendHttp_Json(ServerUrl, jsonReq.ToString(), true, Constants.SERVER_TIMEOUT);
                Constants.LOGGER_DOC.Info("<--" + strRes);

                jsonRes = JObject.Parse(strRes);
                if (jsonRes["code"].ToString().Equals("1"))
                {
                    total_cnt = int.Parse(jsonRes["total_cnt"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
            }

            return total_cnt;
        }

        public string searchReceiptList(string jsonReq)
        {
            string strRes = string.Empty;

            try
            {
                GTF_CommManager comm = new GTF_CommManager(null);

                ServerUrl = Constants.SERVER_URL + "/service/merchant/tfm/searchReceiptList";

                JObject jsonRes = null;

                Constants.LOGGER_DOC.Info("-->" + jsonReq.ToString());
                strRes = comm.sendHttp_Json(ServerUrl, jsonReq.ToString(), true, Constants.SERVER_TIMEOUT);
                Constants.LOGGER_DOC.Info("<--" + strRes);

                jsonRes = JObject.Parse(strRes);
                strRes = jsonRes["list"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
            }

            return strRes;
        }

        public string getDocIdDetails(String strDocId)
        {
            string strReq = string.Empty;
            string strRes = string.Empty;

            try
            {
                GTF_CommManager comm = new GTF_CommManager(null);

                ServerUrl = Constants.SERVER_URL + "/service/merchant/tfm/getDocIdDetails";

                JObject jsonReq = new JObject();
                JObject jsonRes = null;

                jsonReq.Add("doc_id", strDocId);

                Constants.LOGGER_DOC.Info("-->" + jsonReq.ToString());
                strRes = comm.sendHttp_Json(ServerUrl, jsonReq.ToString(), true, Constants.SERVER_TIMEOUT);
                Constants.LOGGER_DOC.Info("<--" + strRes);

                jsonRes = JObject.Parse(strRes);
                strRes = jsonRes["list"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
            }

            return strRes;
        }

        public string getReceiptDetails(String strDocId)
        {
            string strReq = string.Empty;
            string strRes = string.Empty;

            try
            {
                GTF_CommManager comm = new GTF_CommManager(null);

                ServerUrl = Constants.SERVER_URL + "/service/merchant/tfm/getReceiptDetails";

                JObject jsonReq = new JObject();
                JObject jsonRes = null;

                jsonReq.Add("doc_id", strDocId);

                Constants.LOGGER_DOC.Info("-->" + jsonReq.ToString());
                strRes = comm.sendHttp_Json(ServerUrl, jsonReq.ToString(), true, Constants.SERVER_TIMEOUT);
                Constants.LOGGER_DOC.Info("<--" + strRes);

                jsonRes = JObject.Parse(strRes);
                strRes = jsonRes["list"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
            }

            return strRes;
        }

        public bool checkNetworkStatus()
        {
            string strRes = "";

            bool retValue = false;

            try
            {
                GTF_CommManager comm = new GTF_CommManager(null);

                ServerUrl = Constants.SERVER_URL + "/service/merchant/tfm/checkNetworkStatus";

                JObject jsonReq = new JObject();
                JObject jsonRes = null;

                jsonReq.Add("userid", Constants.USER_ID);

                strRes = comm.sendHttp_Json(ServerUrl, jsonReq.ToString(), true, Constants.SERVER_TIMEOUT);

                jsonRes = JObject.Parse(strRes);

                if (jsonRes["code"] != null && jsonRes["code"].ToString().Equals("1"))
                {
                    retValue = true;
                }
            }
            catch (Exception ex)
            {
                Constants.LOGGER_MAIN.Error(ex.Message);
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
            }

            return retValue;
        }

        public string UserInfo(String strUserId)
        {
            string strRes = string.Empty;
            return strRes;
        }

        //서버 전표 등록
        public string Submit()
        {
            string strRes = string.Empty;
            return strRes;
        }

        //서버 전표 등록 최종 확인
        public string Confirm()
        {
            string strRes = string.Empty;
            return strRes;
        }

        //조회
        public string Search()
        {
            string strRes = string.Empty;
            return strRes;
        }

        //세부항목조회
        public string SearchDetail()
        {
            string strRes = string.Empty;
            return strRes;
        }

        //로컬DB 설정값 조회
        public string SearchConfig()
        {
            string strRes = string.Empty;
            return strRes;
        }

        //가장 마지막에 접속한 사용자 정보 업데이트
        public string getLastUserInfo()
        {
            string strRes = string.Empty;
            return strRes;
        }

        //가장 마지막에 접속한 사용자 정보 업데이트
        public string setLastUserInfo()
        {
            string strRes = string.Empty;
            return strRes;
        }

        public static void IgnoreBadCertificates()
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback
             = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
        }
        private static bool AcceptAllCertifications
        (
            object sender,
            System.Security.Cryptography.X509Certificates.X509Certificate certification,
            System.Security.Cryptography.X509Certificates.X509Chain chain,
            System.Net.Security.SslPolicyErrors sslPolicyErrors
        )
        {
            return true;
        }
    }
}
