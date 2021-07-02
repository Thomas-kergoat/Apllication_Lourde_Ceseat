using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetLogiciel_CesEAT
{
    class User
    {
        public string user_id;

        public string user_firstname;

        public string user_lastname;

        public string user_email;

        public string user_password;

        public string user_phonenumber;

        public bool user_is_supported;

        public bool user_support;

        public bool user_is_delivery;

        public int fk_delivery_address_id;

        public int fk_payement_address_id;

        public int fk_credit_card_id;

        public int fk_restorer_id;

        public int fk_role_id;

    }
}
