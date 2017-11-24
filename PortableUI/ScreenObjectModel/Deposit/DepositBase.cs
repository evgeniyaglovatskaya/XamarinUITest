using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableUI.ScreenObjectModel.Deposit
{
    public class DepositBase
    {
        public DepositScreen Deposit = new DepositScreen();
        public Astropay Astropay = new Astropay();
        public AlfaBank AlfaBank = new AlfaBank();
        public Boleto Boleto = new Boleto();
        public CashU CashU = new CashU();
        public MonetaRu MonetaRu = new MonetaRu();
        public Neteller Neteller = new Neteller();
        public OnlineWireTransfer OnlineWireTransfer = new OnlineWireTransfer();
        public Promsvyazbank Promsvyazbank = new Promsvyazbank();
        public QiwiWallet QiwiWallet = new QiwiWallet();
        public Visa Visa = new Visa();
        public VisaCreditCard VisaCreditCard = new VisaCreditCard();
        public Visa3dSecure Visa3DSecure = new Visa3dSecure();
        public WalletOne WalletOne = new WalletOne();
        public WebMoney WebMoney = new WebMoney();
        public YandexMoney YandexMoney = new YandexMoney();
        public YuuPay YuuPay = new YuuPay();
    }
}
