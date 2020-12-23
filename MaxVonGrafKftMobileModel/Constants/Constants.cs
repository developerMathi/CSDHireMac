using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel.Constants
{
    public static class ErrorCodes
    {
        public static readonly string[] AUTHORIZATION_FAILED = { "E0001", "User {0} does not have the function key: {1}." };

        public static readonly string AUTHENTICATION_FAILED = "Invalid username and/or password.";



        public static readonly string[] INVALID_UNAMEPASSWORD = { "E01", "Username or Password is Invalid" };

        public static readonly string[] INACTIVE_USER = { "E02", "User account is inactive or password expired. Please contact administrator" };



        public static readonly string[] MATCHING_OUTGOING_CALL_NOT_FOUND = { "Error", "Could not find matching outgoing call" };

        #region Business ( 0 - 1000) //Serivce

        public static readonly string[] UNKNOWN_ERROR = { "E000", "Unknown error occurred" };
        //public static readonly string[] AUTH_CREDENTIALS_NOT_PROVIDED = { "E001", "Authentication Credentials are not provided" };
        public static readonly string[] AUTH_CREDENTIALS_INVALID = { "E002", "Authentication Credentials are invalid" };
        public static readonly string[] UNAUTHORIZED_ACCESS = { "E003", "Unauthorized Access" };
        public static readonly string[] USER_DOESNOT_HAVE_PERMISSION = { "E004", "User doesn't have permission" };
        public static readonly string[] INVALID_AUTHENTICATION_CONTEXT = { "E005", "Invalid user context" };
        public static readonly string[] INVALID_DATA = { "E006", "Invalid data" };
        public static readonly string[] INVALID_CONFIGURATION = { "E007", "Invalid configuration" };
        public static readonly string[] SAVE_VEHICLE_IMAGE_FAILED = { "E008", "Saving new vehicle image failed" };
        public static readonly string[] SAVE_VEHICLE_MODEL_IMAGE_FAILED = { "E009", "Saving new vehicle model image failed" };
        public static readonly string[] SAVE_IMAGE_FAILED = { "E010", "Saving image failed" };
        public static readonly string[] ADD_VEHICLE_RESERVATION_FAILED = { "E011", "Adding reservation failed" };
        public static readonly string[] RESERVATION_CANCEL_FAILED = { "E012", "Reservation cancel failed. ReservationID={0}" };
        public static readonly string[] SAVE_VEHICLE_FAILED = { "E013", "Saving vehicle failed." };
        public static readonly string[] SAVE_RESERVATION_FAILED = { "E014", "Saving reservation failed" };
        public static readonly string[] INVALID_USER_PROFILE = { "E015", "Invalid user profile" };
        public static readonly string[] AGREEMENT_CANNOT_BE_DELETED = { "E016", "Agreement cannot be deleted." };
        public static readonly string[] AGREEMENT_CAN_BE_DELETED_CLOSE_STATUS = { "E017", "Agreement with status close cannot be deleted." };
        public static readonly string[] INVALID_AGREEMENT = { "E018", "Inavlid agreement. The agreement doesn't exist." };
        public static readonly string[] ERROR_VEHICLE_IMAGE_PATH_CONFIGURATION = { "E019", "Error in vehilce image path configuration." };
        public static readonly string[] DRIVING_LICENSE_VERIFICATION_FAILED = { "E020", "Driving licence verification failed." };
        public static readonly string[] READ_AGREEMENT_HISTORY_FAILED = { "E021", "Error occured when reading agreement history." };
        public static readonly string[] READ_AGREEMENT_HISTORY_LOG_FAILED = { "E022", "Error occured when reading a agreement history log." };
        public static readonly string[] INVALID_RESERVATION = { "E023", "Inavlid Reservation. The Reservation doesn't exist." };
        public static readonly string[] RESERVATION_CANNOT_BE_DELETED = { "E024", "Reservation cannot be deleted." };
        public static readonly string[] AGREEMENT_STATUS_CANNOT_BE_CHANGED = { "E025", "Agreement status cannot be Changed." };
        public static readonly string[] GET_USER_BY_LOCATION_TO_SEND_EMAIL_FAILED = { "E1298", "Error occured when retriving user emails by their location" };
        #endregion

        #region Data Access ( 1001 - 2000) //Repository

        public static readonly string[] INSERT_VEHICLE_FAILED = { "E1001", "Error occurred when insert fleet" };
        public static readonly string[] GET_VEHICLE_MAKE_FAILED = { "E1002", "Error occurred when retriving fleet make" };
        public static readonly string[] GET_ALL_VEHICLE_MAKE_FAILED = { "E1003", "Error occurred when retriving all fleet makes" };
        public static readonly string[] GET_VEHICLE_TYPE_FAILED = { "E1004", "Error occurred when retriving fleet type" };
        public static readonly string[] GET_ALL_VEHICLE_TYPE_FAILED = { "E1005", "Error occurred when retriving all fleet types" };
        public static readonly string[] GET_LOCATION_FAILED = { "E1006", "Error occurred when retriving location" };
        public static readonly string[] GET_ALL_LOCATION_FAILED = { "E1007", "Error occurred when retriving all locations" };
        public static readonly string[] GET_LOCATION_FOR_STOREID_FAILED = { "E1008", "Error occurred when retriving location for store id" };
        public static readonly string[] ADD_NEW_CUSTOMER_ERROR = { "E1009", "Error occurred when adding a new customer" };
        public static readonly string[] SERCH_RESERVATION_FAILED = { "E1010", "Error occurred when serching for reservations" };
        public static readonly string[] UPDATE_VEHICLE_FAILED = { "E1011", "Error occurred when updaing fleet" };
        public static readonly string[] GET_VEHICLE_FAILED = { "E1012", "Error occurred when retriving fleet.fleetID={0}" };
        public static readonly string[] SEARCH_VEHICLE_FAILED = { "E1013", "Error occurred when searching fleets" };
        public static readonly string[] GET_CUSTOMER_FAILED = { "E1014", "Error occurred when retriving customer" };
        public static readonly string[] GET_VEHICLE_IMAGE_FAILED = { "E1015", "Error occurred when retriving fleet image" };
        public static readonly string[] INSERT_VEHICLE_IMAGE_FAILED = { "E1016", "Error occurred when insert fleet image" };
        public static readonly string[] UPDATE_VEHICLE_IMAGE_FAILED = { "E1017", "Error occurred when update fleet image. fleetImageID={0}" };
        public static readonly string[] SEARCH_AVAILABLE_VEHICLES_FAILED = { "E1018", "Error occurred when searching available fleets" };
        public static readonly string[] GET_VEHICLE_MODEL_FAILED = { "E1019", "Error occurred when retriving fleet model" };
        public static readonly string[] GET_RESERVATION_FAILED = { "E1020", "Error occurred when retriving reservation information" };
        public static readonly string[] SEARCH_AGREEMENTS_FAILED = { "NV1021", "Error occurred when searching agreements" };
        public static readonly string[] SEARCH_CUSTOMER_FAILED = { "E1022", "Error occurred when searching customer" };
        public static readonly string[] GET_LEASING_COMPANY_FAILED = { "E1023", "Error occurred when retriving leasing company" };
        public static readonly string[] GET_ALL_LEASING_COMPANY_FAILED = { "E1024", "Error occurred when retriving all leasing companies" };
        public static readonly string[] GET_INSURANCE_COMPANY_FAILED = { "E1025", "Error occurred when retriving insurance company" };
        public static readonly string[] GET_ALL_INSURANCE_COMPANY_FAILED = { "E1026", "Error occurred when retriving all insurance company" };
        public static readonly string[] GET_DRIVERS_FOR_AGREEMENT_FAILED = { "E1027", "Error occurred when retriving drivers for agreenent" };
        public static readonly string[] INSERT_NEW_DRIVER_FAILED = { "E1028", "Error occurred when insert driver" };
        public static readonly string[] UPDATE_DRIVER_FAILED = { "E1029", "Error occurred when update driver" };
        public static readonly string[] INSERT_LOCATION_FAILED = { "E1030", "Error occurred when insert location detail" };
        public static readonly string[] UPDATE_LOCATION_FAILED = { "E1031", "Error occurred when update location detail" };
        public static readonly string[] INSER_RATE_FAIL = { "E1032", "Error occurred when inserting rate detail" };
        public static readonly string[] UPDATE_RATE_FAILED = { "E1033", "Error occurred when update Rate detail" };
        public static readonly string[] GET_VEHICLE_MODEL_IMAGE_FAILED = { "E1034", "Error occurred when retriving fleet model image" };
        public static readonly string[] GET_VEHICLE_MODEL = { "E1035", "Error occurred when retriving fleet model" };
        public static readonly string[] UPDATE_VEHICLE_MAKE_FAILED = { "E1036", "Error occurred when updating fleet make. MakeID = {0}" };
        public static readonly string[] INSERT_VEHICLE_MAKE_FAILED = { "E1037", "Error occurred when inserting fleet make" };
        public static readonly string[] INSERT_VEHICLE_MODEL_FAILED = { "E1038", "Error occurred when inserting fleet model" };
        public static readonly string[] UPDATE_VEHICLE_MODEL_FAILED = { "E1039", "Error occurred when updating fleet model. ModelID = {0}" };
        public static readonly string[] INSERT_VEHICLE_EXPENSE_FAILED = { "E1040", "Error occurred when inserting fleet expense" };
        public static readonly string[] UPDATE_VEHICLE_EXPENSE_FAILED = { "E1041", "Error occurred when updating fleet expense" };
        public static readonly string[] GET_ALL_VEHICLE_EXPENSE_TYPE_FAILED = { "E1042", "Error occurred when retriving fleet expense type" };
        public static readonly string[] GET_ALL_VEHICLE_EXPENSE_FAILED = { "E1043", "Error occurred when retriving fleet expense" };
        public static readonly string[] INSERT_VEHICLE_MODEL_IMAGE_FAILED = { "E1044", "Error occurred when insert model image" };
        public static readonly string[] UPDATE_VEHICLE_MODEL_IMAGE_FAILED = { "E1045", "Error occurred when update model image. fleetModelImageID={0}" };
        public static readonly string[] GET_VEHICLE_MAKE = { "E1046", "Error occurred when retriving fleet make" };
        public static readonly string[] GET_APPLICATION_STATISTICS = { "E1047", "Error occurred when retriving Application Statistics" };
        public static readonly string[] GET_DRIVER_TYPES = { "E1048", "Error occurred when retriving Driver Types" };
        public static readonly string[] GET_AGREEMENT_FAILED = { "NV1049", "Error occurred when retriving agreement" };
        public static readonly string[] GET_ALLYEAR_FAILED = { "E1286", "Error occurred when retriving years by make and model" };
        public static readonly string[] GET_ALLVEHICLE_FAILED = { "E1287", "Error occurred when retriving vehicles" };

        public static readonly string[] INSERT_AGREEMENT_NOTE_FAIL = { "E1050", "Error occurred when inserting agreement note" };
        public static readonly string[] GET_AGREEMENT_NOTE_HISTORY = { "E1051", "Error occurred when retriving agreement note history" };
        public static readonly string[] UPDATE_TAX_FAILED = { "E1052", "Error occurred when updating tax detail" };
        public static readonly string[] DELETE_TAX_FAILED = { "E1053", "Error occurred when deleting tax" };
        public static readonly string[] INSERT_TAX_FAILED = { "E1054", "Error occurred inserting new tax" };
        public static readonly string[] GET_TAX_FAILED = { "E1055", "Error occurred when retriving tax details" };
        public static readonly string[] GET_AGREEMENT_NOTE = { "E1056", "Error occurred when retriving agreement note" };
        public static readonly string[] UPDATE_MISCCHARGE_FAILED = { "E1057", "Error occurred when updating  Miscellaneous charge detail" };
        public static readonly string[] DELETE_MISCCHARGE_FAILED = { "E1058", "Error occurred when deleting  Miscellaneous charge" };
        public static readonly string[] INSERT_MISCCHARGE_FAILED = { "E1059", "Error occurred inserting new  Miscellaneous charge" };
        public static readonly string[] GET_MISCCHARGE_FAILED = { "E1060", "Error occurred when retriving  Miscellaneous charge details" };
        public static readonly string[] GET_MISCCHARGE_FOR_LOCATION_FAILED = { "E1061", "Error occurred when retriving misc chargers for location" };
        public static readonly string[] INSERT_RESERVATION_MISCCHARGE_FAILED = { "E1062", "Error occurred when insert reservation misc charge" };
        public static readonly string[] DELETE_RESERVATION_MISCCHARGE_FAILED = { "E1063", "Error occurred when delete reservation misc charge, ReservationID={0} MiscChargeID={1}" };
        public static readonly string[] GET_ALL_TAXED_BY_LOCATION_FAILED = { "E1064", "Error occurred when retriving taxes by location" };

        public static readonly string[] READ_TAX_FAILED = { "E1065", "Error occurred when retriving tax details" };
        public static readonly string[] READ_MISCCHARGE_FAILED = { "E1066", "Error occurred when retriving misc chargers" };

        public static readonly string[] GET_INSURENCE_DETAIL_FOR_AGREEMENT_FAILED = { "E1067", "Error occurred when retriving insurence detail for agreenent" };
        public static readonly string[] INSERT_AGREEMENT_INSURENCE_FAILED = { "E1068", "Error occurred when insert agreement insurence detail" };
        public static readonly string[] UPDATE_AGREEMENT_INSURENCE_FAILED = { "E1069", "Error occurred when update agreement insurence detail" };
        public static readonly string[] READ_AGREEMENT_INSURENCE_FAILED = { "E1070", "Error occurred when retriving agreement insurence details" };

        public static readonly string[] REMOVE_AGREEMENT_MISCCHARGE_FAILED = { "E1071", "Error occurred when deleting reservation misc charges for AgreementID={0}" };
        public static readonly string[] GET_LOCATIONS_FAILED = { "E1072", "Error occurred when retriving locations" };

        public static readonly string[] AGREEMENT_CHECKOUT_FAILED = { "E1073", "Error occurred when checkout agreement" };
        public static readonly string[] AGREEMENT_CHECKIN_FAILED = { "E1074", "Error occurred when checkin agreement" };
        public static readonly string[] SAVE_VEHICLE_FAILED_LICENSE_EXISTS = { "E1075", "License Number already exits." };
        public static readonly string[] SAVE_VEHICLE_FAILED_VIN_EXISTS = { "E1076", "VIN Number already exits." };
        public static readonly string[] SAVE_VEHICLE_MAKE_FAILED_NAME_EXISTS = { "E1077", "Vehicle make name already exists." };
        public static readonly string[] INSERT_VEHICLE_TYPE_FAILED = { "E1078", "Error occurred when inserting vehicle type." };
        public static readonly string[] SAVE_VEHICLE_TYPE_FAILED_NAME_EXISTS = { "E1079", "Vehicle type name already exists." };
        public static readonly string[] UPDATE_VEHICLE_TYPE_FAILED = { "E1080", "Error occurred when updating vehicle type. TypeID = {0}" };
        public static readonly string[] DELETE_RESERVATION_MISCCHARGE_BY_RESID_FAILED = { "E1081", "Error occurred when delete reservation misc charge, ReservationID={0}" };
        public static readonly string[] DELETE_RESERVATION_TAX_BY_RESID_FAILED = { "E1082", "Error occurred when delete reservation tax, ReservationID={0}" };
        public static readonly string[] GET_RATE_NAME_FOR_LOCATION_FAILED = { "E1083", "Error occurred when reading rate names" };
        public static readonly string[] READ_RATE_FAILED = { "E1084", "Error occurred when reading rate data from data reader" };
        public static readonly string[] GET_RATES_FOR_LOCATION_RATE_NAME_FAILED = { "E1085", "Error occurred when retriving rates for location and rate name" };

        //Referral Errors
        public static readonly string[] GET_REFERRAL_NAMES_FAILED = { "E1086", "Error occurred when retriving referral names" };
        public static readonly string[] GET_REFERRAL_DETAIL_FAILED = { "E1087", "Error occurred when retriving referral details" };
        public static readonly string[] GET_FEATURE_FAILED = { "E1088", "Error occured when retrieving feature for client" };
        public static readonly string[] SAVE_VEHICLE_DAMAGE_FAILED = { "E1089", "Error occurred when inserting vehicle Damage" };
        public static readonly string[] DELETE_VEHICLE_DAMAGE_BY_VEHI_ID_FAILED = { "E1090", "Error occured when deleting vehicle damage detail" };
        public static readonly string[] GET_ALL_VEHICLE_DAMAGE_FAILED = { "E1091", "Error occured when retrieving vehicle damage detail" };

        public static readonly string[] DELETE_AGREEMENT_FAILED = { "NV1092", "Error occured when deleting contract." };
        public static readonly string[] AGREEMENT_DOES_NOT_EXIST = { "E1093", "contract does not exist." };
        public static readonly string[] CANCEL_RESERVATION_FAILED = { "E1094", "Error occurred when canceling reservation. ReservationID={0}" };

        public static readonly string[] GET_TRAFFIC_TICKET_FAILED = { "E1095", "Error occurred when retriving traffic tickets.TrafficTicketId={0}" };
        public static readonly string[] UPDATE_TRAFFIC_TICKET_FAILED = { "E1096", "Error occurred when update traffic ticket detail.TrafficTicketId={0}" };
        public static readonly string[] INSERT_TRAFFIC_TICKET_FAILED = { "E1097", "Error occurred when insert traffic ticket detail" };
        public static readonly string[] UPDATE_VEHICLE_STATUS_FAILED = { "E1098", "Error occurred when update vehicle status for vehice Id : {0}" };

        public static readonly string[] GET_VEHICLES_BY_VEHICLE_TYPE_FAILED = { "E1099", "Error occurred when getting vehicles for vehice type Id : {0} for Location Id : {1}" };

        public static readonly string[] GET_LEASING_COMPANYS_FAILED = { "E1100", "Error occurred when retriving leasing Companies" };
        public static readonly string[] UPDATE_LEASING_COMPANY_FAILED = { "E1101", "Error occurred when update leasing Company detail" };
        public static readonly string[] INSERT_LEASING_COMPANY_FAILED = { "E1102", "Error occurred when insert leasing Company detail" };
        public static readonly string[] GET_LEASING_COMPANYS_BY_ID_FAILED = { "E1103", "Error occurred when retriving leasing Company by id" };

        public static readonly string[] GET_INSURANCE_COMPANYS_FAILED = { "E1104", "Error occurred when retriving insurance Companies" };
        public static readonly string[] UPDATE_INSURANCE_COMPANY_FAILED = { "E1105", "Error occurred when update insurance Company detail" };
        public static readonly string[] INSERT_INSURANCE_COMPANY_FAILED = { "E1106", "Error occurred when insert insurance Company detail" };
        public static readonly string[] GET_INSURANCE_COMPANYS_BY_ID_FAILED = { "E1107", "Error occurred when retriving insurance Company by id" };

        public static readonly string[] EXCHANGE_VEHICLE_FAILED = { "E1108", "Error occurred when exchanging vehicle for contract Id : {0}" };
        public static readonly string[] GET_VEHICLE_EXCHANGES_FAILED = { "E1109", "Error occurred when gettting vehicle exchanges for contract Id : {0}" };

        public static readonly string[] GET_USERS_FAILED = { "E1110", "Error occurred when retriving users" };
        public static readonly string[] UPDATE_USER_FAILED = { "NV1111", "Error occurred when update user detail" };
        public static readonly string[] INSERT_USER_FAILED = { "E1112", "Error occurred when insert user detail" };
        public static readonly string[] GET_USER_BY_ID_FAILED = { "E1113", "Error occurred when retriving user by id" };
        public static readonly string[] INSERT_MAX_USER_FAILED = { "E1114", "Error occurred when inserting maximum user" };
        public static readonly string[] GET_USER_ROLE_FAILED = { "E1115", "Error occurred when retriving user role name" };

        public static readonly string[] GET_REFERRAL_FAILED = { "E1116", "Error occurred when retriving referrals detail" };
        public static readonly string[] UPDATE_REFERRAL_FAILED = { "E1117", "Error occurred when update referral detail" };
        public static readonly string[] INSERT_REFERRAL_FAILED = { "E1118", "Error occurred when insert referral detail" };

        public static readonly string[] GET_REFERRAL_BY_ID_FAILED = { "E1119", "Error occurred when retriving referral detail by id" };
        public static readonly string[] DELETE_AGREEMENT_NOTE_FAILED = { "E1120", "Error occurred when deleting Note" };
        public static readonly string[] UPDATE_AGREEMENT_NOTE_FAILED = { "E1121", "Error occurred when updating Note" };

        public static readonly string[] GET_INVOICE_FAILED = { "NV1122", "Error occurred when retriving invoice detail" };
        public static readonly string[] UPDATE_INVOICE_FAILED = { "E1123", "Error occurred when update invoice detail" };
        public static readonly string[] INSERT_INVOICE_FAILED = { "E1124", "Error occurred when insert invoice detail" };
        public static readonly string[] DELETE_INVOICE_FAILED = { "E1125", "Error occurred when deleting invoice detail" };

        public static readonly string[] GET_PAYMENT_FAILED = { "E1126", "Error occurred when retriving payment detail" };
        public static readonly string[] UPDATE_PAYMENT_FAILED = { "E1127", "Error occurred when update payment detail" };
        public static readonly string[] INSERT_PAYMENT_FAILED = { "E1128", "Error occurred when insert payment detail" };
        public static readonly string[] DELETE_PAYMENT_FAILED = { "E1129", "Error occurred when deleting payment detail" };

        public static readonly string[] UPDATE_RESERVATION_FAILED = { "E1030", "Error occurred when updaing reservation. ReservationID={0}" };
        public static readonly string[] READ_VEHICLE_OPTION_FAILED = { "E1031", "Error occurred when reading vehicle options" };
        public static readonly string[] GET_ALL_VEHICLE_OPTIONS_FAILED = { "E1032", "Error occurred when retriving all vehicle options" };
        public static readonly string[] DELETE_ALL_VEHICLE_OPTIONS_FAILED = { "E1033", "Error occurred when deleting all vehicle options for VehicleID={0}" };
        public static readonly string[] INSERT_VEHICLE_OPTIONS_MAPPING_FAILED = { "E1034", "Error occurred when inserting vehicle options for VehicleID={0} VehicleOptionID={1}" };
        public static readonly string[] DELETE_VEHICLE_OPTIONS_MAPPING_FAILED = { "E1035", "Error occurred when deleting vehicle options for VehicleID={0} VehicleOptionID={1}" };

        public static readonly string[] INSERT_RESERVATION_TAX_FAILED = { "E1036", "Error occurred when insert reservation tax" };

        public static readonly string[] INSERT_AGREEMENT_TAX_FAILED = { "E1037", "Error occurred when insert contract tax" };
        public static readonly string[] INSERT_AGREEMENT_MISCCHARGE_FAILED = { "E1038", "Error occurred when insert contract misc charge" };
        public static readonly string[] DELETE_AGREEMENT_MISCCHARGE_FAILED = { "E1039", "Error occurred when delete contract misc charge, contractID={0} MiscChargeID={1}" };
        public static readonly string[] INSERT_BILLING_INFO_FAIL = { "E1140", "Error occurred when insert contract billing information" };
        public static readonly string[] UPDATE_BILLING_INFO_FAIL = { "E1141", "Error occurred when update contract billing information" };

        public static readonly string[] INSERT_COMPANY_EXPENSE_FAIL = { "E1142", "Error occurred when inserting company expense" };
        public static readonly string[] INSERT_COMPANY_EXPENSE_ITEM_FAIL = { "E1143", "Error occurred when inserting company expense item" };
        public static readonly string[] UPDATE_COMPANY_EXPENSE_FAILED = { "E1144", "Error occurred when updating company expense item" };
        public static readonly string[] UPDATE_COMPANY_EXPENSE_ITEM_FAILED = { "E1145", "Error occurred when updating company expense item" };
        public static readonly string[] GET_COMPANY_EXPENSE_FAILED = { "E1146", "Error occurred when retriving company expense detail" };
        public static readonly string[] DELETE_COMPANY_EXPENSE_FAILED = { "E1147", "Error occurred when deleting company expense detail" };
        public static readonly string[] DELETE_VEHICLE_MAKE_FAILED = { "E1148", "Error occurred when deleting vehicle make" };
        public static readonly string[] DELETE_VEHICLE_MODEL_FAILED = { "E1149", "Error occurred when deleting vehicle model" };
        public static readonly string[] SAVE_VEHICLE_MODEL_FAILED_NAME_EXISTS = { "E1150", "Vehicle model already exists." };
        public static readonly string[] DELETE_VEHICLE_MAKE_FAILED_RECORDS_EXISTS = { "E1151", "Cannot delete vehicle make \"{0}\"! It is being used by vehicles" };
        public static readonly string[] DELETE_VEHICLE_MODEL_FAILED_RECORDS_EXISTS = { "E1152", "Cannot delete vehicle model \"{0}\"! It is being used by vehicles" };
        public static readonly string[] DELETE_VEHICLE_TYPE_FAILED_RECORDS_EXISTS = { "E1153", "Cannot delete vehicle type \"{0}\"! It is being used by vehicles" };
        public static readonly string[] DELETE_VEHICLE_TYPE_FAILED = { "E1154", "Error occurred when deleting vehicle type" };
        public static readonly string[] GET_VEHICLE_OPTION_BY_ID_FAILED = { "E1155", "Error occurred when retrieving vehicle option" };
        public static readonly string[] INSERT_VEHICLE_OPTION_FAILED = { "E1156", "Error occurred when inserting vehicle option" };
        public static readonly string[] SAVE_VEHICLE_OPTION_FAILED_NAME_EXISTS = { "E1157", "vehicle option already exists" };
        public static readonly string[] UPDATE_VEHICLE_OPTION_FAILED = { "E1158", "Error occurred when updating vehicle option. OptionID = {0}" };
        public static readonly string[] DELETE_VEHICLE_OPTION_FAILED_RECORDS_EXISTS = { "E1159", "Cannot delete vehicle option \"{0}\"! It is being used by vehicles" };
        public static readonly string[] DELETE_VEHICLE_OPTION_FAILED = { "E1160", "Error occurred when deleting vehicle option" };
        public static readonly string[] ADD_NEW_ADDRESS_ERROR = { "E1161", "Error occurred when adding address" };
        public static readonly string[] UPDATE_ADDRESS_ERROR = { "E1162", "Error occurred when updating address" };
        public static readonly string[] ADD_NEW_CREDITCARD_ERROR = { "E1163", "Error occurred when adding credit card" };
        public static readonly string[] UPDATE_CREDITCARD_ERROR = { "E1164", "Error occurred when updating credit card" };
        public static readonly string[] SEARCH_CUSTOMER_ADDRESS_FAILED = { "E1165", "Error occurred when retreiving customer addresses" };
        public static readonly string[] DELETE_CUSTOMER_ADDRESS_FAILED = { "E1166", "Error occurred when deleting customer address" };

        public static readonly string[] SEARCH_CUSTOMER_CREDITCARD_FAILED = { "E1167", "Error occurred when retreiving customer credit cards" };
        public static readonly string[] DELETE_CUSTOMER_CREDITCARD_FAILED = { "E1168", "Error occurred when deleting customer credit card" };
        //  ----------------------
        public static readonly string[] GET_ALL_STORE_HOUR_FAILED = { "E1169", "Error occurred when retrieving all store hours" };

        public static readonly string[] GET_STORE_HOURS_BY_DAY_FAILED = { "E1170", "Error occurred when retrieving store hours by day" };
        public static readonly string[] INSERT_MISCCHARGE_OPTION_FAILED = { "E1171", "Error occurred when inserting miscallaneous charge option" };

        public static readonly string[] UPDATE_RESERVATION_MODULE_FAILED = { "E1172", "Error occurred when updating reservation module" };
        public static readonly string[] GET_COMPANY_EXPENSE_ITEM_FAILED = { "E1173", "Error occurred when retrieving company expense item" };

        public static readonly string[] GET_MISCCHARGE_OPTION_FAILED = { "E1174", "Error occurred when retrieving updating miscallaneous charge option" };

        public static readonly string[] DELETE_MISCCHARGE_OPTION_FAILED = { "E1175", "Error occurred when deleting miscallaneous charge option" };
        public static readonly string[] DELETE_COMPANY_EXPENSE_ITEM_FAILED = { "E1176", "Error occurred when deleting company expense item" };
        public static readonly string[] GET_RESERVATION_MODULE_FAILED = { "E1177", "Error occurred when retrieving reservation module" };
        public static readonly string[] GET_NEXT_OIL_CHANGE_FAILED = { "E1178", "Error occurred when retrieving next oil change" };
        public static readonly string[] GET_RATE_TYPES_FAILED = { "E1179", "Error occurred when retrieving rate types" };
        public static readonly string[] DELETE_INVOICE_ITEM_FAILED = { "E1180", "Error occurred when deleting invoice item" };
        public static readonly string[] CHECK_AGREEMENT_NO_EXIST_FAILED = { "E1181", "Error occurred when checking if contract number exist" };
        public static readonly string[] GET_AUTO_AGREEMENT_NO_FAILED = { "E1182", "Error occurred when getting auto contract number" };

        public static readonly string[] GET_INVOICE_ITEM_FAILED = { "E1183", "Error occurred when retrieving invoice item" };
        public static readonly string[] INSERT_INVOICE_ITEM_FAILED = { "E1184", "Error occurred when inserting invoice item" };
        public static readonly string[] UPDATE_INVOICE_ITEM_FAILED = { "E1185", "Error occurred when updating invoice item" };
        public static readonly string[] INSERT_AGREEMENT_FAILED = { "E1186", "Error occurred when adding contract" };

        public static readonly string[] UPDATE_AGREEMENT_FAILED = { "E1187", "Error occurred when updating contract" };
        public static readonly string[] INSERT_VEHICLE_EXCHANGE = { "E1188", "Error occurred when inserting vehicle exchange" };
        public static readonly string[] GET_CHECK_OUT_LOCATION_FAILED = { "E1189", "Error occurred when retrieving check out location" };
        public static readonly string[] GET_CHECK_IN_LOCATION_FAILED = { "E1190", "Error occurred when retrieving check in location" };
        public static readonly string[] GET_RETURN_LOCATION_FAILED = { "E1191", "Error occurred when retrieving return location" };
        public static readonly string[] GET_RATE_FAILED = { "E1192", "Error occurred when retrieving rate" };
        public static readonly string[] READ_BILLING_INFO_FAILED = { "E1193", "Error occurred when retrieving billing information" };

        public static readonly string[] UPDATE_TOLL_DETAIL_FAILED = { "E1194", "Error occurred when updating toll detail" };
        public static readonly string[] GET_CHART_DATASOURCE_FAILED = { "E1195", "Error occurred when retrieving chart data source" };

        public static readonly string[] GET_FEATURE_ATTRIBUTE_FAILED = { "E1196", "Error occurred when retrieving feature attribute" };
        public static readonly string[] INSERT_TOLL_HEADER_FAILED = { "E1197", "Error occurred when inserting toll header" };

        public static readonly string[] INSERT_CLIENT_FAILED = { "E1198", "Error occurred when inserting client" };
        public static readonly string[] UPDATE_CLIENT_FAILED = { "NV1199", "Error occurred when updating client" };

        public static readonly string[] GET_CLIENT_FAILED = { "NV1200", "Error occurred when retrieving client" };
        public static readonly string[] INSERT_TOLL_DETAIL = { "E1201", "Error occurred when inserting toll detail" };
        public static readonly string[] UPDATE_CUSTOMER_ERROR = { "E1202", "Error occurred when updating customer" };

        public static readonly string[] ADD_DRIVER_LICENSE_CHECK_FAILED = { "E1203", "Error occurred when adding driver license check" };
        public static readonly string[] GET_LOCATION_FOR_STATEID_FAILED = { "E1204", "Error occurred when retreiving locations for the state" };
        public static readonly string[] GET_STATES_FAILED = { "E1205", "Error occurred when retrieving states" };
        public static readonly string[] GET_COUNTRIES_FAILED = { "E1206", "Error occurred when retrieving countries" };

        public static readonly string[] GET_STATE_FAILED = { "E1207", "Error occurred when retrieving state" };
        public static readonly string[] GET_COUNTRY_FAILED = { "NV1208", "Error occurred when retrieving country" };
        public static readonly string[] DELETE_RATE_FAILED = { "E1209", "Error occurred when deleting rate" };
        public static readonly string[] GET_RATE_NAMES_BY_CLIENT_ID_FAILED = { "E1210", "Error occurred when retrieving rate names by client id" };
        public static readonly string[] INSERT_RESERVATION_FAILED = { "E1211", "Error occurred when inserting reservation" };
        public static readonly string[] GET_LEASE_EXPIRE_FAILED = { "E1212", "Error occurred when retrieving lease expiry" };
        public static readonly string[] VEHICLE_NO_EXIST_CHECK_FAILED = { "E1213", "Error occurred when checking for vehicle number" };
        public static readonly string[] GET_VEHICLE_MODELS_FAILED = { "E1214", "Error occurred when retrieving vehicle models" };
        public static readonly string[] GET_VEHICLE_SUMMARY_FAILED = { "E1215", "Error occurred when retrieving vehicle summary" };
        public static readonly string[] GET_VEHICLE_TYPE_IMAGE_FAILED = { "E1216", "Error occurred when retrieving vehicle type image" };
        public static readonly string[] UPDATE_MISCCHARGE_OPTION_FAILED = { "E1217", "Error occurred when updating miscallaneous charge option" };
        public static readonly string[] GET_RATE_DETAILS_FAILED = { "E1218", "Error occurred when retrieving rate details" };
        public static readonly string[] GET_TOLL_REPORT_FAILED = { "E1219", "Error occurred when retrieving toll report" };
        public static readonly string[] DELETE_CLIENT_FEATURE_FAILED = { "E1220", "Error occurred when deleting client feature" };
        public static readonly string[] UPDATE_CLIENT_FEATURE_FAILED = { "E1221", "Error occurred when updating client feature" };

        public static readonly string[] ADD_NEW_CLIENT_FEATURE_FAILED = { "E1222", "Error occurred when adding new client feature" };
        public static readonly string[] GET_CLIENT_DOCS_FAILED = { "E1223", "Error occurred when retrieving client documents" };
        public static readonly string[] ADD_CLIENT_DOC_FAILED = { "NV1224", "Error occurred when adding client document" };
        public static readonly string[] GET_USED_FILE_SIZE_FAILED = { "E1225", "Error occurred when retrieving used file size" };
        public static readonly string[] DELETE_CLIENT_DOCUMENT_FAILED = { "E1226", "Error occurred when deleting client document" };
        public static readonly string[] GET_MAX_FILE_SIZE_FAILED = { "E1227", "Error occurred when retrieving max file size" };

        public static readonly string[] ADD_SHARED_LOCATION_FAILED = { "E1228", "Error occurred when adding shared location" };
        public static readonly string[] DELETE_ALL_SHARED_LOCATIONS_FAILED = { "E1229", "Error occurred when deleting all shared locations" };
        public static readonly string[] GET_LOCATION_BY_VEHICLE_FAILED = { "E1230", "Error occurred when retriving location by vehicle" };
        public static readonly string[] GET_COMBINED_LOCATIONS_BY_LOCATION_ID = { "E1231", "Error occurred when retriving combined locations by vehicle" };

        public static readonly string[] INSERT_VEHICLE_FAILED_VEHICLE_NO_EXISTS = { "E1232", "Vehicle Number already exits." };

        public static readonly string[] GET_ALL_EQUIPMENT_TYPE_FAILED = { "E1233", "Error occured when get all equipment type." };
        public static readonly string[] GET_ALL_EQUIPMENT_FAILED = { "E1234", "Error occured when get contract equipment ." };
        public static readonly string[] GET_ALL_EQUIPMENT_BY_ID_FAILED = { "E1235", "Error occured when get equipment by id." };
        public static readonly string[] ADD_EQUIPMENT_FAILED = { "E1236", "Error occured when inserting new equipment." };
        public static readonly string[] EDIT_EQUIPMENT_FAILED = { "E1236", "Error occured when editing equipment." };
        public static readonly string[] DELETE_EQUIPMENT_FAILED = { "E1236", "Error occured when deleting equipment." };

        public static readonly string[] GET_ALL_SEASON_RATE_FAILED = { "E1237", "Error occured when get all season rate." };

        public static readonly string[] GET_SEASON_RATE_BY_ID_FAILED = { "E1238", "Error occured when get season rate by id." };
        public static readonly string[] ADD_SEASON_RATE_FAILED = { "E1239", "Error occured when inserting new season rate." };
        public static readonly string[] EDIT_SEASON_RATE_FAILED = { "E1240", "Error occured when editing season rate." };
        public static readonly string[] DELETE_SEASON_RATE_FAILED = { "E1241", "Error occured when deleting season rate." };
        public static readonly string[] GET_AGREEMENT_HISTORY_FAILED = { "E1242", "Error occured when getting contract history." };
        public static readonly string[] GET_AGREEMENT_HISTORY_LOG_FAILED = { "E1243", "Error occured when getting a contract history log." };

        public static readonly string[] GET_ALL_VEHICLE_TRACK_FAILED = { "E1242", "Error occured when get all vehicle track." };

        public static readonly string[] GET_VEHICLE_TRACK_BY_ID_FAILED = { "E1243", "Error occured when get vehicle track by id." };
        public static readonly string[] ADD_VEHICLE_TRACK_FAILED = { "E1244", "Error occured when inserting new vehicle track." };
        public static readonly string[] EDIT_VEHICLE_TRACK_FAILED = { "E1245", "Error occured when editing vehicle track." };
        public static readonly string[] DELETE_VEHICLE_TRACK_FAILED = { "E1246", "Error occured when deleting vehicle track." };

        public static readonly string[] FILL_DROP_DOWN_LIST_FAILED = { "E1247", "Error occurred when filling the drop down list" };
        public static readonly string[] GET_REPORT_CONFIGURATION_FAILED = { "E1248", "Error occurred when retriving report configuration" };
        public static readonly string[] EXECUTE_REPORT_CONFIGURATION = { "E1249", "Error occurred when executing report configuration" };
        public static readonly string[] GET_REPORT_FAILED = { "E1250", "Error occurred when retriving report" };

        public static readonly string[] SEARCH_RESERVATION_FAILED = { "E1251", "Error occurred when search reservation" };

        public static readonly string[] GET_VEHICLE_NOTE_HISTORY = { "E1252", "Error occurred when retriving report" };
        public static readonly string[] DELETE_VEHICLE_NOTE_FAILED = { "E1253", "Error occurred when deleting note" };
        public static readonly string[] UPDATE_VEHICLE_NOTE_FAILED = { "E1254", "Error occurred when updating Note" };
        public static readonly string[] INSERT_VEHICLE_NOTE_FAIL = { "E1255", "Error occurred when inserting vehicle note" };

        public static readonly string[] GET_CUSTOMER_NOTE_HISTORY = { "E1256", "Error occurred when retriving note" };
        public static readonly string[] DELETE_CUSTOMER_NOTE_FAILED = { "E1257", "Error occurred when deleting note" };
        public static readonly string[] UPDATE_CUSTOMER_NOTE_FAILED = { "E1258", "Error occurred when updating note" };
        public static readonly string[] INSERT_CUSTOMER_NOTE_FAIL = { "E1259", "Error occurred when inserting vehicle note" };

        public static readonly string[] GET_CUSTOMINVOICE_FAILED = { "E1260", "Error occurred when retriving Custom invoice detail" };
        public static readonly string[] DELETE_RESERVATION_FAILED = { "E1261", "Error occured when deleting reservation." };
        public static readonly string[] GET_DOCUMENTS_FAILED = { "E1261", "Error occured when getting documents." };
        public static readonly string[] NO_PERMISSION_TOGET_DOCUMENTS = { "E1261", "Error occured when getting documents." };
        public static readonly string[] GET_MAPPED_CLIENT_ID_FAILED = { "E1262", "Error occurred when retriving mapped client id" };

        public static readonly string[] INSERT_DROPOFFCHARGE_FAILED = { "NV1263", "Error occured when trying to insert the dropoff charge record." };
        public static readonly string[] DELETE_DROPOFFCHARGE_FAILED = { "NV1264", "Error occured when deleting the record." };
        public static readonly string[] UPDATE_DROPOFFCHARGE_FAILED = { "NV1265", "Error occured when updating the record." };
        public static readonly string[] GET_DROPOFFCHARGE_FAILED = { "NV1266", "Error occured when get the record." };


        public static readonly string[] GET_VEHICLE_RESERVATION_FEATURES_FAILED = { "E1265", "Error occured when getting reservation features." };
        public static readonly string[] GET_ALL_VEHICLE_RESERVATION_FEATURES_FAILED = { "E1266", "Error occured when getting all reservation features." };
        public static readonly string[] UPDATE_VEHICLE_RESERVATION_FEATURES_FAILED = { "E1267", "Error occured when updating reservation features." };
        public static readonly string[] INSERT_VEHICLE_RESERVATION_FEATURES_FAILED = { "E1268", "Error occured when inserting reservation features." };
        public static readonly string[] DELETE_VEHICLE_RESERVATION_FEATURES_FAILED = { "E1269", "Error occured when deleting reservation features." };

        //ku
        public static readonly string[] GET_AGREEMENTCHARGE_FEATURES_FAILED = { "E1270", "Error occured when getting agreement charge features." };
        public static readonly string[] GET_ALL_AGREEMENTCHARGE_FEATURES_FAILED = { "E1271", "Error occured when getting all agreement charge features." };
        public static readonly string[] UPDATE_AGREEMENTCHARGE_FEATURES_FAILED = { "E1272", "Error occured when updating agreement charge features." };
        public static readonly string[] INSERT_AGREEMENTCHARGE_FEATURES_FAILED = { "E1273", "Error occured when inserting agreement charge features." };
        public static readonly string[] DELETE_AGREEMENTCHARGE_FEATURES_FAILED = { "E1274", "Error occured when deleting agreement charge features." };
        public static readonly string[] GET_AGREEMENTCHARGETYPE_FEATURES_FAILED = { "E1275", "Error occured when getting agreement charge type features." };
        public static readonly string[] UPDATE_FINE_PAYMENT_FAILED = { "E1276", "Error occurred when update Fine Payment(Trafic Ticket) detail" };

        // Promotion Name
        public static readonly string[] INSERT_PROMOTIONCODENAME_FAILED = { "E1278", "Error occured when trying to insert the promo Code Name record." };
        public static readonly string[] GET_PROMOTIONCODENAME_NAMES_BY_CLIENT_ID_FAILED = { "E1279", "Error occurred when retrieving Promotion Code names by client id" };

        //Promotions Add
        public static readonly string[] INSERT_PROMOTION_FAILED = { "E1280", "Error occured when trying to insert the Promotions record." };
        public static readonly string[] UPDATE_PROMOTION_FAILED = { "E1281", "Error occured when updating the Promotions record." };
        public static readonly string[] DELETE_PROMOTION_FAILED = { "E1282", "Error occured when deleting the Promotions record." };
        public static readonly string[] GET_PROMOTIONS_NAMES_BY_CLIENT_ID_FAILED = { "E1283", "Error occurred when retrieving Promotions names by client id" };
        public static readonly string[] GET_PROMOTIONS_FAILED = { "E1284", "Error occurred when retrieving Promotions names by client id" };
        public static readonly string[] GET_PROMOTIONS_BYVEHICLEID_FAILED = { "E1285", "Error occurred when retrieving Promotions names by Vehicle ID" };
        //deposit
        public static readonly string[] GET_DEPOSIT_FAILED = { "E1286", "Error occurred when retriving deposit detail" };
        public static readonly string[] UPDATE_DEPOSIT_FAILED = { "E1287", "Error occurred when update deposit detail" };
        public static readonly string[] INSERT_DEPOSIT_FAILED = { "E1288", "Error occurred when insert deposit detail" };
        public static readonly string[] DELETE_DEPOSIT_FAILED = { "E1289", "Error occurred when deleting deposit detail" };

        public static readonly string[] DELETE_AGREEMENT_TAX_FAILED = { "NV1290", "Error occured when deleting agreementTax." };
        public static readonly string[] DELETE_AGREEMENT_MISCHARGE_FAILED = { "E1291", "Error occured when deleting agreementMisCharge." };
        public static readonly string[] DELETE_RESERVATION_TAX_FAILED = { "E1292", "Error occured when deleting reservationTax." };
        public static readonly string[] DELETE_RESERVATION_MISCHARGE_FAILED = { "E1293", "Error occured when deleting reservationMisCharge." };

        //update reservation misc charge...
        public static readonly string[] UPDATE_RESERVATION_MISCHARGE_FAILED = { "E1294", "Error occured when updating reservationMisCharge." };
        //Custom reports
        public static readonly string[] GET_CUSTOM_SUMMARY_REPORTS = { "E1295", "Error occured when retriving custom summary report." };

        //
        public static readonly string[] GET_SEQUENCE_NUMBER_FAILED = { "E1296", "Error occurred when retring sequence number" };
        public static readonly string[] UPDATE_SEQUENCE_NUMBER_FAILED = { "E1297", "Error occured when updating sequence number." };
        public static readonly string[] GET_PAYMENT_GATEWAY_DETAILS_FAILED = { "E1298", "Error occured when retriving payment gateway details." };

        //service Type
        public static readonly string[] GET_ALL_SERVICE_TYPES_FAILED = { "E1299", "Error occured when retriving all service type details." };
        public static readonly string[] INSERT_SERVICE_TYPES_FAILED = { "E1300", "Error occured when inserting service type details." };
        public static readonly string[] UPDATE_SERVICE_TYPES_FAILED = { "E1301", "Error occured when updating service type details." };
        public static readonly string[] GET_SERVICE_TYPES_FAILED = { "E1302", "Error occured when retriving the service type details. " };
        public static readonly string[] DELETE_SERVICE_TYPES_FAILED = { "E1303", "Error occured when deleting service type details. " };

        //Vendor 
        public static readonly string[] GET_ALL_VENDOR_FAILED = { "E1304", "Error occured when retriving all vendor details." };
        public static readonly string[] INSERT_VENDOR_FAILED = { "E1305", "Error occured when inserting vendor details." };
        public static readonly string[] UPDATE_VENDOR_FAILED = { "E1306", "Error occured when updating vendor details." };
        public static readonly string[] GET_VENDOR_FAILED = { "E1307", "Error occured when the vendor details " };
        public static readonly string[] DELETE_VENDOR_FAILED = { "E1308", "Error occured when deleting vendor details " };

        //Authorized Service Employee
        public static readonly string[] GET_ALL_AUTHORIZED_EMPLOYEES_FAILED = { "E1309", "Error occured when retriving all authorized employee details." };
        public static readonly string[] INSERT_AUTHORIZED_EMPLOYEES_FAILED = { "E1310", "Error occured when inserting authorized employee details. " };
        public static readonly string[] UPDATE_AUTHORIZED_EMPLOYEES_FAILED = { "E1311", "Error occured when updating authorized employee details." };
        public static readonly string[] GET_AUTHORIZED_EMPLOYEES_BY_ID_FAILED = { "E1312", "Error occured when retriving authorized employee details. " };
        public static readonly string[] DELETE_AUTHORIZED_EMPLOYEES_FAILED = { "E1313", "Error occured when deleting authorized employee details." };

        //pmServiceSetUp
        public static readonly string[] GET_ALL_PM_SERVICESETUP_FAILED = { "E1314", "Error occured when retriving all pm service set up details." };
        public static readonly string[] INSERT_PM_SERVICESETUP_FAILED = { "E1315", "Error occured when inserting pm service set up details. " };
        public static readonly string[] UPDATE_PM_SERVICESETUP_FAILED = { "E1316", "Error occured when updating pm service set up details." };
        public static readonly string[] GET_PM_SERVICESETUP_BY_ID_FAILED = { "E1317", "Error occured when retriving pm service set up details. " };
        public static readonly string[] DELETE_PM_SERVICESETUP_FAILED = { "E1318", "Error occured when deleting pm service set up details." };

        //ServiceTypeItem  SERVICE_TYPE_ITEM
        public static readonly string[] GET_ALL_SERVICE_TYPE_ITEM_FAILED = { "E1319", "Error occured when retriving allServiceTypeItem details." };
        public static readonly string[] INSERT_SERVICE_TYPE_ITEM_FAILED = { "E1320", "Error occured when inserting ServiceTypeItem details. " };
        public static readonly string[] UPDATE_SERVICE_TYPE_ITEM_FAILED = { "E1321", "Error occured when updating ServiceTypeItem details." };
        public static readonly string[] GET_SERVICE_TYPE_ITEM_BY_ID_FAILED = { "E1322", "Error occured when retriving ServiceTypeItem details. " };
        public static readonly string[] DELETE_SERVICE_TYPE_ITEM_FAILED = { "E1323", "Error occured when deleting ServiceTypeItem details." };

        // vehicle maintenance service
        public static readonly string[] GET_ALL_VEHICLE_MAINTENANCE_SERVICE_FAILED = { "E1324", "Error occured when retriving all vehicle maintenance service details." };
        public static readonly string[] INSERT_VEHICLE_MAINTENANCE_SERVICE_FAILED = { "E1325", "Error occured when inserting vehicle maintenance service details." };
        public static readonly string[] UPDATE_VEHICLE_MAINTENANCE_SERVICE_FAILED = { "E1326", "Error occured when updatingvehicle maintenance service details." };
        public static readonly string[] GET_VEHICLE_MAINTENANCE_SERVICE_BY_ID_FAILED = { "E1327", "Error occured when the vehicle maintenance service details " };
        public static readonly string[] DELETE_VEHICLE_MAINTENANCE_SERVICE_FAILED = { "E1328", "Error occured when deleting vehicle maintenance service details " };

        // serviceItem froservice
        public static readonly string[] GET_ALL_SERVICE_ITEM_FOR_PM_SERVICE_SERVICE_FAILED = { "E1324", "Error occured when retriving all vehicle maintenance service details." };
        public static readonly string[] INSERT_SERVICE_ITEM_FOR_PM_SERVICE_SERVICE_FAILED = { "E1325", "Error occured when inserting service item for Pm service" };
        public static readonly string[] UPDATE_SERVICE_ITEM_FOR_PM_SERVICE_SERVICE_FAILED = { "E1326", "Error occured when updatingvehicle maintenance service details." };

        public static readonly string[] GET_ALL_PM_SERVICE_BY_VEHICLEID_FAILED = { "E1327", "Error occured when get all pm service details for vehicle." };
        public static readonly string[] GET_ALL_PM_SERVICE_BY_PMID_FAILED = { "E1327", "Error occured when get all pm service details for pm id." };
        public static readonly string[] GET_ALL_TYPE_FAILED = { "E1328", "Error occurred when retriving all types." };

        // Payement GatewayDetails
        public static readonly string[] INSERT_PAYMENTGATEWAYDETAILS_FAILED = { "E1329", "Error occured when Inserting payment gateway details." };
        public static readonly string[] EDIT_PAYMENTGATEWAYDETAILS_FAILED = { "E1330", "Error occured when Updating payment gateway details." };

        public static readonly string[] GET_RATES_FOR_CALCULATIONS_FAILED = { "E1331", "Error occurred when retrieving rates for base calculations" };
        public static readonly string[] INSERT_RATES_FOR_CALCULATIONS_FAILED = { "E1332", "Error occured when inserting  rates for base calculations" };
        public static readonly string[] UPDATE_RATES_FOR_CALCULATIONS_FAILED = { "E1333", "Error occured when updating Rates for base calculations" };
        public static readonly string[] DELETE_RATES_FOR_CALCULATIONS_FAILED = { "E1334", "Error occured when deleting rates for base calculations" };

        public static readonly string[] GET_ALL_CLIENT_APP_SETTING_BY_CLIENTID_FAILED = { "E1335", "Error occured when retriving clientAppSetting" };

        // Penalty Configurations
        public static readonly string[] SEARCH_PENALTY_CONFIGURATION_FAILED = { "E1336", "Error occured when Searching penalty configurations." };
        public static readonly string[] ADD_PENALTY_CONFIGURATION_FAILED = { "E1337", "Error occured when Adding penalty configurations." };
        public static readonly string[] UPDATE_PENALTY_CONFIGURATION_FAILED = { "E1338", "Error occured when Updating penalty configurations." };
        public static readonly string[] DELETE_PENALTY_CONFIGURATION_FAILED = { "E1339", "Error occured when Deleting penalty configurations." };

        // Late payment
        public static readonly string[] SEARCH_LATE_PAYMENT_FAILED = { "E1345", "Error occured when Searching Late Payments." };

        // Track payment
        public static readonly string[] ADD_TRACK_PAYMENT_FAILED = { "NV1346", "Error occurred when add Track Payment." };
        public static readonly string[] GET_ALL_TRACK_PAYMENT_FAILED = { "NV1347", "Error occurred when retriving all Track Payments." };
        public static readonly string[] GET_TRACK_PAYMENT_BY_CLIENTID_FAILED = { "NV1348", "Error occurred when retriving Track Payment." };
        public static readonly string[] UPDATE_TRACK_PAYMENTS_FAILED = { "NV1349", "Error occurred when Updating all Track Payments." };
        public static readonly string[] DELETE_TRACK_PAYMENTS_FAILED = { "NV1350", "Error occurred when Deleting all Track Payments." };

        // Client missing constants
        public static readonly string[] GET_ALL_CLIENTS_FAILED = { "NV1351", "Error occurred when retrieving all clients." };
        public static readonly string[] GET_ACTIVATE_DEACTIVATE_CLIENT = { "NV1352", "Error occurred when actiavting deactive client." };
        public static readonly string[] GET_SEARCHED_CLIENTS_FAILED = { "NV1353", "Error occurred when retrieving serached clients." };

        // CLinet-Product
        public static readonly string[] GET_CLIENT_PRODUCT_BY_ID_FAILED = { "NV1354", "Error occurred when retrieving client product by id." };
        public static readonly string[] UPDATE_CLIENT_PRODUCT_BY_ID_FAILED = { "NV1355", "Error occurred when updating client product by id." };
        public static readonly string[] DELETE_CLIENT_PRODUCTS_BY_ID_FAILED = { "NV1356", "Error occurred when deleting client product." };
        public static readonly string[] ADD_CLIENT_PRODUCT_FAILED = { "NV1357", "Error occurred when adding client product." };
        public static readonly string[] GET_ALL_CLIENT_PRODUCTS_FAILED = { "NV1358", "Error occurred when retrieving all client product" };

        // CLinet-Notes
        public static readonly string[] ADD_CLIENT_NOTES_FAILED = { "NV1359", "Error occurred when adding client notes." };
        public static readonly string[] GET_ALL_CLIENT_NOTES_FAILED = { "NV1360", "Error occurred when retrieving all client notes." };
        public static readonly string[] GET_CLIENT_NOTES_BY_ID_FAILED = { "NV1361", "Error occurred when retrieving client notes by id." };
        public static readonly string[] UPDATE_CLIENT_NOTES_FAILED = { "NV1362", "Error occurred when updating client notes." };
        public static readonly string[] DELETE_CLIENT_NOTES_FAILED = { "NV1363", "Error occurred when deleting client notes." };

        // Clinet-Mail
        public static readonly string[] SAVE_CLIENT_MAIL_FAILED = { "NV1364", "Error occurred when saving client mail." };
        public static readonly string[] GET_CLIENT_MAIL_FAILED = { "NV1365", "Error occurred when retrieving client mail." };

        // Client Payment Related
        public static readonly string[] GET_ALL_CLIENT_PAYMENTS_FAILED = { "NV1366", "Error occurred when retrieving all client payments." };
        public static readonly string[] GET_CLIENT_PAYMENT_DUE = { "NV1367", "Error occurred when retrieving client payment due." };
        public static readonly string[] SEARCH_CLIENT_PAYMENT_DUE = { "NV1368", "Error occurred when searching client payment due." };

        // Lead
        public static readonly string[] GET_LEAD_SUMMARY_FAILED = { "NV1369", "Error occurred when retrieving lead summary." };
        public static readonly string[] SEARCH_LEAD_SUMMARY_FAILED = { "NV1370", "Error occurred when Searching lead summary." };
        public static readonly string[] ADD_LEAD_SUMMARY_FAILED = { "NV1371", "Error occurred when adding lead summary." };
        public static readonly string[] UPDATE_LEAD_SUMMARY_FAILED = { "NV1372", "Error occurred when Updating lead summary." };

        public static readonly string[] GET_LEAD_STATUS_FAILED = { "NV1373", "Error occurred when retrieving lead status." };

        public static readonly string[] DELETE_LEAD_FAILED = { "NV1374", "Error occurred when deleting lead." };
        public static readonly string[] GET_ALL_LEAD_FAILED = { "NV1375", "Error occurred when retrieving all leads." };

        public static readonly string[] GET_LEAD_NOTES_BY_ID_FAILED = { "NV1376", "Error occurred when retrieving lead notes." };
        public static readonly string[] ADD_LEAD_NOTES_BY_ID_FAILED = { "NV1377", "Error occurred when adding lead notes." };
        public static readonly string[] UPDATE_LEAD_NOTES_BY_ID_FAILED = { "NV1378", "Error occurred when updating lead notes." };
        public static readonly string[] GET_ALL_LEAD_NOTES_BY_ID_FAILED = { "NV1379", "Error occurred when retrieving all lead notes." };
        public static readonly string[] DELETE_LEAD_NOTES = { "NV1380", "Error occurred when deleting lead notes." };

        public static readonly string[] GET_LEAD_PRODUCT_FAILED = { "NV1381", "Error occurred when retrieving lead product." };
        public static readonly string[] UPDATE_LEAD_PRODUCT_FAILED = { "NV1382", "Error occurred when updating lead product." };
        public static readonly string[] DELETE_LEAD_PRODUCT_FAILED = { "NV1383", "Error occurred when deleting lead product." };
        public static readonly string[] GET_ALL_LEAD__PRODUCT_BY_ID_FAILED = { "NV1384", "Error occurred when retrieving all lead product." };
        public static readonly string[] ADD_LEAD_PRODUCT_BY_ID_FAILED = { "NV1385", "Error occurred when adding lead product." };

        // Squence Number
        public static readonly string[] GET_ALL_SEQUENCE_NUMBER_FAILED = { "NV1386", "Error occurred when retring all sequence numbers." };
        public static readonly string[] UPDATE_SEQUENCE_FAILED = { "NV1387", "Error occurred when updating sequence." };

        // Agreement
        public static readonly string[] ADD_AGREEMENT_FAILED = { "NV1388", "Error occurred when adding agreement." };
        public static readonly string[] ADD_AGREEMENT_RATES_FAILED = { "NV1389", "Error occurred when adding agreement rates." };
        public static readonly string[] ADD_DRIVER_FAILED = { "NV1390", "Error occurred when adding driver." };
        public static readonly string[] INSERT_DRIVER_FAILED = { "NV1391", "Error occurred when inserting driver." };
        public static readonly string[] ADD_AGREEMENT_BILLING_FAILED = { "NV1392", "Error occurred when adding agreement billing." };
        public static readonly string[] ADD_AGREEMENT_INSURANCE_FAILED = { "NV1393", "Error occurred when adding agreement insurance." };
        public static readonly string[] ADD_AGREEMENT_PAYMENT_FAILED = { "NV1394", "Error occurred when adding agreement payment.." };
        public static readonly string[] ADD_ADVANCE_PAYMENT_IN_CHECKOUT_FAILED = { "NV1395", "Error occurred when adding advance payment in checkout." };
        public static readonly string[] ADD_MIGRATE_RESERVATION_PAYMENT_DETAILS_FAILED = { "NV1396", "Error occurred when adding migrate reservation payment details." };
        public static readonly string[] ADD_MIGRATE_RESERVATION_DEPOSIT_DETAILS_FAILED = { "NV1397", "Error occurred when adding migrate reservation deposit details." };
        public static readonly string[] ADD_AGREEMENT_TAX_FAILED = { "NV1398", "Error occurred when adding agreement tax." };
        public static readonly string[] ADD_AGREEMENT_MISC_CHARGE_FAILED = { "NV1399", "Error occurred when adding agreement misc charge." };
        public static readonly string[] ADD_AGREEMENT_NOTE_FAILED = { "NV1400", "Error occurred when adding agreement note." };
        public static readonly string[] ADD_AGREEMENT_EQUIPMENT_FAILED = { "NV401", "Error occurred when adding agreement equipment." };
        public static readonly string[] CHECK_IN_AGREEMENT_FAILED = { "NV402", "Error occurred when checkin agreement." };
        public static readonly string[] SAVE_AGREEMENT_INSURANCE_FAILED = { "NV403", "Error occurred when saving agreement insurance." };
        public static readonly string[] ADD_INVOICE_ON_AGREEMENT_FAILED = { "NV404", "Error occurred when adding invoice on agreement." };
        public static readonly string[] ADD_EDIT_AGREEMENT_RESERVATION_MILEAGE_BREAKDOWN_FAILED = { "NV405", "Error occurred when add edit ageement reservation mileage breakdown." };
        public static readonly string[] UPDATE_AGREEMENT_MISC_CHARGE_FAILED = { "NV1406", "Error occurred when updating misc charge in agreement." };
        public static readonly string[] UPDATE_AGREEMENT_INSURANCE_FAILED = { "NV1407", "Error occurred when updating insurance in agreement." };
        public static readonly string[] UPDATE_AGREEMENT_BILLING_FAILED = { "NV1408", "Error occurred when updating billing in agreement." };
        public static readonly string[] UPDATE_DIVER_FAILED = { "NV1409", "Error occurred when updating driver." };
        public static readonly string[] UPDATE_AGREEMENT_EQUIPMENT_FAILED = { "NV1410", "Error occurred when updating equipement in agreement." };
        public static readonly string[] UPDATE_AGREEMENT_TOTAL_FAILED = { "NV1411", "Error occurred when updating total in agreement." };
        public static readonly string[] CHANGE_AGREEMENT_STATUS_FAILED = { "NV1412", "Error occurred when changing status in agreement." };
        public static readonly string[] DELETE_AGREEMENT_RATE_FAILED = { "NV1413", "Error occurred when deleting agreement rate." };
        public static readonly string[] DELETE_AGREEMENT_MISC_CHARGE_FAILED = { "NV1414", "Error occurred when deleting agreement misc charge." };
        public static readonly string[] DELETE_AGREEMENT_EQUIPMENT_FAILED = { "NV1415", "Error occurred when deleting agreement equipment." };
        public static readonly string[] DELETE_AGREEMENT_PROMOTION_FAILED = { "NV1416", "Error occurred when deleting agreement promotion." };
        public static readonly string[] GET_AGREEMENT_REVIEW_SET_FAILED = { "NV1417", "Error occurred when retrieving agreement review set." };
        public static readonly string[] GET_AGREEMENT_BASIC_DATA_FAILED = { "NV1418", "Error occurred when retrieving agreement basic data." };
        public static readonly string[] GET_AGREEMENT_BASIC_INFO_FAILED = { "NV1419", "Error occurred when  retrieving agreement basic info." };
        public static readonly string[] GET_ALL_AGREEMENT_RATES_FAILED = { "NV1420", "Error occurred when retrieving all agreement rates." };
        public static readonly string[] GET_ALL_AGREEMENT_STATUS_FAILED = { "NV1421", "Error occurred when retrieving all agreement status." };
        public static readonly string[] GET_ALL_REFERRAL_NAMES = { "NV1422", "Error occurred when retrieving all referral names." };
        public static readonly string[] GET_ALL_EQUIPMENT_TYPES_FAILED = { "NV1423", "Error occurred when retrieving all equipment types." };
        public static readonly string[] GET_AGREEMENT_TAX_FAILED = { "NV1424", "Error occurred when retrieving agreement tax." };
        public static readonly string[] GET_AGREEMENT_NOTE_FAILED = { "NV1425", "Error occurred when retrieving agreement note." };
        public static readonly string[] GET_AGREEMENT_EQUIPMENT_FAILED = { "NV1426", "Error occurred when retrieving agreement equipment." };
        public static readonly string[] GET_AGREEMENT_DRIVER_LIST_FAILED = { "NV1427", "Error occurred when retrieving agreement driver list." };
        public static readonly string[] GET_REFERRAL_DETAILS_FAILED = { "NV1428", "Error occurred when retrieving referral details." };
        public static readonly string[] GET_AGREEMENT_PDF_FAILED = { "NV1429", "Error occurred when retrieving agreement PDF." };
        public static readonly string[] GET_AUTO_INCREMENT_NUMBER_FAILED = { "NV1430", "Error occurred when retrieving auto-increment number." };
        public static readonly string[] GET_QUICK_CHECK_IN_AGREEMENT_FAILED = { "NV1431", "Error occurred when retrieving quick check in agreement." };
        public static readonly string[] DELETE_AGREEMENT_DRIVER_FAILED = { "NV1432", "Error occurred when deleting agreement driver." };
        public static readonly string[] GET_MILEAGE_BREAKDOWN_CHRAGE_FOR_EXTRA_MILEGE_FAILED = { "NV1433", "Error occured when retrieving milege breakdown charge for extra milege." };
        public static readonly string[] GET_AGREEMENT_ID_FAILED = { "NV1434", "Error occurred when retrieving agreement id." };
        public static readonly string[] GET_PENDING_PAYMENT_AGREEMENT_FAILED = { "NV1435", "Error occurred when retrieving pending payment agreement." };
        public static readonly string[] ADD_EDIT_RIST_NOTE_FAILED = { "NV1436", "Error occurred when add edit Rist note." };
        public static readonly string[] SERACH_AGREEMENT_TO_EXCEL_FAILED = { "NV1437", "Error occurred when searching agreement to excel." };

        // AgreementType
        public static readonly string[] GET_ALL_AGREEMENT_TYPES_FAILED = { "NV1438", "Error occurred when retrieving agreement type." };
        public static readonly string[] UPDATE_TYPE_FAILED = { "NV1439", "Error occurred when updating agreement type." };

        // AgreementCharge
        public static readonly string[] ADD_AGREEMENT_CHARGE_FAILED = { "NV1441", "Error occurred when adding agreemnet charge." };
        public static readonly string[] DELETE_AGREEMENT_CHARGE_FAILED = { "NV1442", "Error occurred when deleting agreemnet charge." };
        public static readonly string[] UPDATE_AGREEMENT_CHARGE_FAILED = { "NV1443", "Error occurred when updating agreemnet charge." };
        public static readonly string[] GET_AGREEMENT_CHARGE_FAILED = { "NV1444", "Error occurred when retrieving agreemnet charge." };
        public static readonly string[] GET_ALL_AGREEMENT_CHARGE_FAILED = { "NV1445", "Error occurred when retrieving all agreemnet charge." };
        public static readonly string[] GET_AGREEMENT_CHARGE_TOTAL_FAILED = { "NV1446", "Error occurred when retrieving agreemnet charge total." };

        // AgreementChargeType
        public static readonly string[] GET_AGREEMENT_CHARGE_TYPE_FAILED = { "NV1447", "Error occurred when retrieving agreement charge type." };

        // User
        public static readonly string[] GET_ACTIVATE_DEACTIVATE_USER_FAILED = { "NV1448", "Error occurred when activate deactivate user." };

        // Product
        public static readonly string[] GET_PRODUCT_BY_ID_FAILED = { "NV1449", "Error occurred when retrieving product by id." };
        public static readonly string[] GET_ALL_PRODUCT_BY_ID_FAILED = { "NV1450", "Error occurred when retrieving all product." };
        public static readonly string[] GET_PRODUCT_NAME_FAILED = { "NV1451", "Error occurred when retrieving product name." };

        // API-user
        public static readonly string[] ADD_API_USER_FAILED = { "NV1452", "Error occurred when adding API user." };
        public static readonly string[] GET_ALL_API_USERS_FAILED = { "NV1453", "Error occurred when retrieving all API user." };

        public static readonly string[] GET_ATTACHMENT_TYPE_CLIENT_ID_FAILED = { "NV1454", "Error occurred when retrieving attachment type client ID." };
        public static readonly string[] GET_ATTACHMENT_TYPE_DETAIL_BY_ATTACHMENT_TYPE_ID_FAILED = { "NV1455", "Error occurred when retrieving attachment type detail by attachment type id." };
        public static readonly string[] GET_ATTACHMENT_DETAIL_BY_ATTACHMENT_ID_FAILED = { "NV1456", "Error occurred when retrieving attachment detail by attachment id." };
        public static readonly string[] GET_ATTACHMENT_DETAIL_FAILED = { "NV1457", "Error occurred when retrieving attachment detail." };
        public static readonly string[] GET_ATTACHMENTS_NAMES_FAILED = { "NV1458", "Error occurred when retrieving attachment's name." };
        public static readonly string[] GET_ALL_VEHICLE_ATTACHMENT_FAILED = { "NV1459", "Error occurred when retrieving all attachments." };
        public static readonly string[] SEARCH_ATTACHMENT_COLUMNS_FAILED = { "NV1460", "Error occurred when searching attachment columns." };
        public static readonly string[] GET_ATTACHMENT_NAMES_BY_VEHICLE_ID_FAILED = { "NV1460", "Error occurred when retrieving attachment names by vehicle id." };
        public static readonly string[] GET_ATTACHMENT_TYPE_NAME_BY_ATTACHMENT_TYPE_ID_FAILED = { "NV1461", "Error occurred when retrieving attachment type by attachment type id." };
        public static readonly string[] ADD_NEW_ATTACHMENT_FAILED = { "NV1462", "Error occurred when adding a new attachment" };
        public static readonly string[] ADD_ATTACHMENT_DETAILS_VALUE_FAILED = { "NV1463", "Error occurred when adding a new attachment venue" };
        public static readonly string[] ADDD_VEHICLE_ATTACHMENT_FAILED = { "NV1464", "Error occurred when adding a new attachment" };
        public static readonly string[] UPDATE_ATTACHMENT_DETAILS_VALUE_FAILED = { "NV1465", "Error occurred when updating an attachment detail value" };
        public static readonly string[] DELETE_VEHICLE_ATTACHMENTS_FAILED = { "NV1466", "Error occurred when deleting a vehicle attachment" };
        public static readonly string[] DELETE_ATTACHMENTS_FAILED = { "NV1467", "Error occurred when deleting an attachment" };
        public static readonly string[] GET_ATTACHMENT_TYPE_DETAIL_FAILED = { "NV1468", "Error occurred when retrieving an attachment type detail" };
        public static readonly string[] GET_DYNAMIC_DATA_FAILED = { "NV1469", "Error occurred when retrieving dynamic data" };
        public static readonly string[] GET_ATTRIBUTES_FOR_RESERVATION_FAILED = { "NV1470", "Error occurred when retrieving Attributes for Reservation" };
        public static readonly string[] GET_ATTRIBUTES_FOR_AGREEMENT_FAILED = { "NV1471", "Error occurred when retrieving Attributes for Agreement" };
        public static readonly string[] ADD_AGREEMENT_ATTRIBUTES_FAILED = { "NV1472", "Error occurred when Adding Attributes" };
        public static readonly string[] ADD_RESERVATION_ATTRIBUTES_FAILED = { "NV1473", "Error occurred when Adding Reservation Attributes" };
        public static readonly string[] UPDATE_AGREEMENT_ATTRIBUTES_FAILED = { "NV1474", "Error occurred when Updating Agreeement Attributes" };
        public static readonly string[] UPDATE_RESERVATION_ATTRIBUTES_FAILED = { "NV1475", "Error occurred when Updating Reservation Attributes" };
        public static readonly string[] GET_AGREEMENT_ATTRIBUTE_VALUES_BY_ID_FAILED = { "NV1476", "Error occurred when retrieving Agreement Attributes Value by ID" };
        public static readonly string[] GET_RESERVATION_ATTRIBUTE_VALUES_BY_ID_FAILED = { "NV1477", "Error occurred when retrieving reservation Attributes Value by ID" };
        public static readonly string[] GET_CLIENT_ATTRIBUTE_FAILED = { "NV1478", "Error occurred when retrieving reservation Attributes Value by ID" };
        public static readonly string[] ADD_BLACKOUT_DAY_FAILED = { "NV1479", "Error occurred when adding Black Out Day" };
        public static readonly string[] UPDATE_BLACKOUT_DAY_FAILED = { "NV1480", "Error occurred when Updating Black Out Day" };
        public static readonly string[] DELETE_BLACKOUT_DAY_FAILED = { "NV1481", "Error occurred when Deleting Black Out Day" };
        public static readonly string[] GET_ALL_BLACKOUT_DAYS_FAILED = { "NV1482", "Error occurred when retrieving all Black Out Days" };
        public static readonly string[] GET_BLACKOUT_DAY_BY_ID_FAILED = { "NV1483", "Error occurred when retrieving Black Out Day by ID" };
        public static readonly string[] GET_BASIC_AGREEMENT_BLACKOUT_INFO_FAILED = { "NV1484", "Error occurred when retrieving Basic Agreement Blackout Info" };
        public static readonly string[] GET_INACTIVE_DAY_DEDUCTION_AMOUNT_FAILED = { "NV1485", "Error occurred when retrieving Inactive day deduction amount" };
        public static readonly string[] DELETE_BLACKOUT_DAYS_BY_REFERENCE_ID = { "NV1486", "Error occurred when deleting Blackout Days by Reference ID" };
        public static readonly string[] ADD_BLACK_OUT_DAYS_CONFIG = { "NV1486", "Error occurred when Adding Blackout Days Config" };
        public static readonly string[] UPDATE_TOTAL_DAYS = { "NV1487", "Error occurred when updating total days" };


        public static readonly string[] ADD_CustomerINVOICE_FAILED = { "NV1488", "Error occurred when retriving customer invoice detail" };


        //NNV-3514 - GPS Tracking Software

        public static readonly string[] ADD_GPS_CLIENT_FAILED = { "NV3514", "Error occurred when Adding GPS Client" };
        public static readonly string[] UPDATE_GPS_CLIENT_FAILED = { "NV3514", "Error occurred when Updating GPS Client" };
        public static readonly string[] ADD_GPS_ASSET_FAILED = { "NV3514", "Error occurred when Adding GPS Asset" };
        public static readonly string[] UPDATE_GPS_ASSET_FAILED = { "NV3514", "Error occurred when Updating GPS Asset" };
        public static readonly string[] DELETE_GPS_ASSET_FAILED = { "NV3514", "Error occurred when Deleting GPS Asset" };
        public static readonly string[] DELETE_GPS_CLIENT_FAILED = { "NV3514", "Error occurred when Deleting GPS Client" };
        public static readonly string[] SEARCH_GPS_ASSET_FAILED = { "NV3514", "Error occurred when Searching GPS Asset" };
        public static readonly string[] DELETE_GPS_FENCE_FAILED = { "NV3514", "Error occurred when Deleting GPS Fence" };
        public static readonly string[] SAVE_LINK_GPS_ASSET_FAILED = { "NV3514", "Error occurred when Updating Save Link GPS Asset" };



        #endregion

        #region [Presentation ( 2001 - 3000) ] //Controller 

        public static readonly string[] INSERT_BLACKOUTDAY_FAILED = { "NV2001", "Error occured when trying to insert the BlackoutDay record." };
        public static readonly string[] DELETE_BLACKOUTDAY_FAILED = { "NV2002", "Error occured when deleting the BlackoutDay record." };
        public static readonly string[] GET_BLACKOUTDAY_FAILED = { "NV2003", "Error occured when get the BlackoutDay record." };
        public static readonly string[] ADD_PAYMENT_FAILED = { "NV2004", "Error occured when Add Payment." };
        public static readonly string[] ADD_PAYMENT_CLIENT_FAILED = { "NV2005", "Error occured when Add Payment Client." };
        public static readonly string[] ADD_TRACK_PAYMENTS_FAILED = { "NV2006", "Error occured when Add Track Payment." };
        public static readonly string[] GET_CILENT_FAILED = { "NV2007", "Error occured when get Clients." };
        public static readonly string[] GET_MONTHS_FAILED = { "NV2008", "Error occured when get Months." };
        public static readonly string[] GET_PAYMENT_TYPE_FAILED = { "NV2009", "Error occured when get Payment Type." };
        public static readonly string[] GET_YEARS_FAILED = { "NV20010", "Error occured when get Years." };
        public static readonly string[] LEAD_TYPES_FAILED = { "NV20011", "Error occured when Lead Types." };
        public static readonly string[] MANAGE_TRACK_PAYMENT_FAILED = { "NV20012", "Error occured when Manage Track Payment." };
        public static readonly string[] MANAGE_TRACK_CLIENT_PAYMENTS_FAILED = { "NV20013", "Error occured when Manage Track client Payments." };
        public static readonly string[] MANAGE_LEAD_SUMMARY_FAILED = { "NV20013", "Error occured when Manage Lead Summary." };
        public static readonly string[] EDIT_TRACK_PAYMENT_FAILED = { "NV20014", "Error occured when Edit Track Payment." };
        public static readonly string[] UPDATE_TRACK_PAYMENT_FAILED = { "NV20015", "Error occured when Update Track Payment." };
        public static readonly string[] DELETE_TRACK_PAYMENT_FAILED = { "NV20016", "Error occured when Delete Track Payment." };
        public static readonly string[] SEARCH_TRACK_PAYMENT_FAILED = { "NV20017", "Error occured when Search Track Payment." };
        public static readonly string[] VIEW_SEQUENTCE_FAILED = { "NV20018", "Error occured when View Sequence." };
        public static readonly string[] EDIT_SEQUENTCE_FAILED = { "NV20019", "Error occured when Edit Sequence." };
        public static readonly string[] CLIENT_ACTIVATION_FAILED = { "NV20020", "Error occured when Client Activation." };
        public static readonly string[] ADD_CLIENT_FAILED = { "NV20021", "Error occured when Add Client." };
        public static readonly string[] MANAGE_LEADS_FAILED = { "NV20022", "Error occured when Manage Leads." };
        public static readonly string[] SEARCH_BY_TOTAL_LEADS_FAILED = { "NV20013", "Error occured when Search By Total Leads." };
        public static readonly string[] SEARCH_LEADS_FAILED = { "NV20023", "Error occured when Search Leads." };
        public static readonly string[] ADD_LEADS_FAILED = { "NV20024", "Error occured when Add Leads." };
        public static readonly string[] ADD_EDIT_LEADS_VIEW_FAILED = { "NV20025", "Error occured when Add Edit Leads View." };
        public static readonly string[] REVIEW_LEADS_VIEW_FAILED = { "NV20026", "Error occured when Add Review Leads View." };
        public static readonly string[] ADD_PRODUCT_FAILED = { "NV20027", "Error occured when Add Product." };
        public static readonly string[] ADD_CLIENT_PRODUCTS_FAILED = { "NV20028", "Error occured when Add Client Product." };
        public static readonly string[] SAVE_NOTE_FAILED = { "NV20029", "Error occured when save note." };
        public static readonly string[] SAVE_PRODUCT_FAILED = { "NV20030", "Error occured when save product." };
        public static readonly string[] SAVE_PRODUCT_TEMP_FAILED = { "NV20031", "Error occured when Save Products Temp." };
        public static readonly string[] SAVE_TEMP_NOTE_FAILED = { "NV20032", "Error occured when save temp note." };
        public static readonly string[] REMOVE_FROM_PRODUCT_LIST_FAILED = { "NV20033", "Error occured when Remove From Product List." };
        public static readonly string[] REMOVE_FROM_NOTE_LIST_FAILED = { "NV20034", "Error occured when Remove From note List." };
        public static readonly string[] NOTE_GRID_FAILED = { "NV20035", "Error occured when Note Grid." };
        public static readonly string[] PRODUCT_GRID_FAILED = { "NV20036", "Error occured when product Grid." };
        public static readonly string[] DELETE_LEADS_FAILED = { "NV200137", "Error occured when Delete Lead." };
        public static readonly string[] GET_LEAD_NOTE_BY_ID_FAILED = { "NV20038", "Error occured when Get Lead Note By Id." };
        public static readonly string[] GET_PRODUCT_BY_IDS_FAILED = { "NV20039", "Error occured when Get Product By Id." };
        public static readonly string[] EDIT_TEMP_PRODUCT_FAILED = { "NV20040", "Error occured when Edit Temp Product." };
        public static readonly string[] EDIT_TEMP_NOTE_FAILED = { "NV20041", "Error occured when Edit Temp note." };
        public static readonly string[] UPDATE_TEMP_PRODUCT_LIST_FAILED = { "NV20042", "Error occured when Update Temp Product List." };
        public static readonly string[] UPDATE_TEMP_NOTE_LIST_FAILED = { "NV20043", "Error occured when Update Temp note List." };
        public static readonly string[] BULK_UPLOAD_FAILED = { "NV20044", "Error occured when Bulk Upload." };
        public static readonly string[] UPLOAD_ITEM_FAILED = { "NV20045", "Error occured when Upload Item." };
        public static readonly string[] GET_USER_NAME_BY_CLIENT_FAILED = { "NV20046", "Error occured when Get User name By Client." };
        public static readonly string[] API_USERS_FAILED = { "NV20047", "Error occured when Api Users." };
        public static readonly string[] API_USERS_GRID_FAILED = { "NV20048", "Error occured when Api Users Gird." };
        public static readonly string[] SHOW_API_USERS_FAILED = { "NV20047", "Error occured when Show Api Users." };
        public static readonly string[] ADD_API_USERS_FAILED = { "NV20048", "Error occured when Add Api Users." };
        public static readonly string[] API_CONSUMER_TYPE_FAILED = { "NV20049", "Error occured when Api Concumer Type." };
        public static readonly string[] GENARATE_KEYS_FAILED = { "NV20050", "Error occured when Genarate Keys." };
        public static readonly string[] REVIEW_CLIENTS_VIEW_FAILED = { "NV20051", "Error occured when Review Clients View." };
        public static readonly string[] CREATE_USER_MODEL_FAILED = { "NV20052", "Error occured when Create user model." };
        public static readonly string[] GET_EMAIL_HISTORY_LIST_CLIENT_FAILED = { "NV20051", "Error occured when Get Email History List Client." };
        public static readonly string[] PRODUCT_NAME_FAILED = { "NV20053", "Error occured when Product Name." };
        public static readonly string[] SAVE_CLIENT_PRODUCT_FAILED = { "NV20054", "Error occured when Save Client Product." };
        public static readonly string[] SAVE_CLIENT_NAME_FAILED = { "NV20055", "Error occured when Save Client Mail." };
        public static readonly string[] EDIT_TEMP_CLIENT_PRODUCT_FAILED = { "NV20056", "Error occured when Edit Temp Client Product." };
        public static readonly string[] UPDATE_TEMP_CLIENT_PRODUCT_LIST_FAILED = { "NV20057", "Error occured when Update Temp Client Product List." };
        public static readonly string[] REMOVE_FROM_CLIENT_PRODUCT_LIST_FAILED = { "NV20058", "Error occured when Remove From Client Product List." };
        public static readonly string[] PRODUCT_CLIENT_GRID_FAILED = { "NV20059", "Error occured when Product Client Grid." };
        public static readonly string[] EMAIL_HISTORY_CLIENT_GRID_FAILED = { "NV20060", "Error occured when Email History Client Grid." };
        public static readonly string[] SAVE_CLIENT_NOTES_FAILED = { "NV20061", "Error occured when Save Client Notes." };
        public static readonly string[] NOTE_CLIENT_GRID_FAILED = { "NV20062", "Error occured when Note Client Grid." };
        public static readonly string[] EDIT_TEMP_CLIENT_NOTE_FAILED = { "NV20063", "Error occured when Edit Temp Client Note." };
        public static readonly string[] UPDATE_TEMP_CLIENT_NOTE_FAILED = { "NV20064", "Error occured when Update Temp Client Note." };
        public static readonly string[] REMOVE_FROM_CLIENT_NOTE_LIST_FAILED = { "NV20065", "Error occured when Remove From Client Note List." };
        public static readonly string[] SHOW_EMAIL_DETAILS_FAILED = { "NV20066", "Error occured when Show Email Details." };
        public static readonly string[] PAYMENT_CLIENT_GRID_FAILED = { "NV20067", "Error occured when Payment Client Grid." };
        public static readonly string[] EDIT_TEMP_CLIENTPAYMENT_FAILED = { "NV20068", "Error occured when Edit Temp Client Payment." };
        public static readonly string[] PAYMENT_DUE_FAILED = { "NV20069", "Error occured when Payment Due." };
        public static readonly string[] EDIT_DUE_PAYMENT_FAILED = { "NV20070", "Error occured when Edit Due Payment." };
        public static readonly string[] UPDATE_DUE_PAYMENT_FAILED = { "NV20071", "Error occured when Update Due Payment." };
        public static readonly string[] COUNTRY_FAILED = { "NV20072", "Error occured when Country." };
        public static readonly string[] SATATE_FAILED = { "NV20072", "Error occured when State." };
        public static readonly string[] SATATES_FAILED = { "NV20073", "Error occured when States." };
        public static readonly string[] LEAD_SUB_STATUSES_FAILED = { "NV20074", "Error occured when Lead Sub Statuses." };
        public static readonly string[] EMPLOYEES_FAILED = { "NV20075", "Error occured when Employees." };
        public static readonly string[] MANAGE_CLIENT_FAILED = { "NV20076", "Error occured when Manage client." };
        public static readonly string[] SEARCH_FAILED = { "NV20077", "Error occured when Search." };
        public static readonly string[] CLIENT_EDIT_FAILED = { "NV20078", "Error occured when Client edit." };
        public static readonly string[] CLIENT_UPDATE_FAILED = { "NV20079", "Error occured when Client Update." };
        public static readonly string[] SHOW_CLIENT_USERS_FAILED = { "NV20080", "Error occured when Show Client Users." };
        public static readonly string[] USER_UPDATE_FAILED = { "NV20081", "Error occured when User update." };
        public static readonly string[] GET_STATE_FOR_COUNTRY_FAILED = { "NV20082", "Error occured when Get State For County." };
        public static readonly string[] GET_SYMBOLS_FOR_CURRENCY_CODE_FAILED = { "NV20083", "Error occured when Get Symbols For Currency Code." };
        public static readonly string[] GET_SUB_STATUS_FOR_STATUS_FAILED = { "NV20084", "Error occured when Get SubS tatus ForS tatus." };
        public static readonly string[] VIEW_AGING_REPORT_FAILED = { "NV20085", "Error occured when View Aging Report." };
        public static readonly string[] EXPORT_TO_EXCEL_AGING_REPORT_FAILED = { "NV20086", "Error occured when Export To Excel Aging Report." };
        public static readonly string[] GET_AGINIG_SEARCH_LIST_FAILED = { "NV20087", "Error occured when Get Aging Search List." };
        public static readonly string[] CREATE_MODEL_FAILED = { "NV20088", "Error occured when create model." };
        public static readonly string[] CHARGE_TYPE_FAILED = { "NV20089", "Error occured when Charge Type." };
        public static readonly string[] CHARGE_TYPES_WITH_INVOICE_TYPES_FAILED = { "NV20090", "Error occured when Charge Types With Invoice Types." };
        public static readonly string[] MANAGE_AGREEMENT_CHARGE_FAILED = { "NV20091", "Error occured when Manage Agreement Charge." };
        public static readonly string[] LIST_AGREEMENT_CHARGES_FAILED = { "NV20092", "Error occured when List Agreement Charges." };
        public static readonly string[] DELETE_AGREEMENT_CHARGES_FAILED = { "NV20093", "Error occured when Delete Agreement Charges." };
        public static readonly string[] ADD_EDIT_AGREEMENT_CHARGES_FAILED = { "NV20094", "Error occured when Add edit Agreement Charges." };
        public static readonly string[] MANAGE_AGREEMENT_HISTORY_FAILED = { "NV20095", "Error occured when Manage Agreement History." };
        public static readonly string[] CAMPARE_CHANGES_FAILED = { "NV20096", "Error occured when Compare Changes." };
        public static readonly string[] ADD_BLACKOUTDAY_CONFIG_FAILED = { "NV20097", "Error occured when Add BlackOutDays Config." };
        public static readonly string[] BLACKOUTDAY_LIST_FAILED = { "NV20098", "Error occured when BlackOutDays list." };
        public static readonly string[] MANAGE_UPLOAD_FAILED = { "NV20099", "Error occured when Manage upload." };
        public static readonly string[] UPLOAD_FILE_FAILED = { "NV200100", "Error occured when upload File." };
        public static readonly string[] DOWNLOAD_VEHICLE_TEMPLATE_FAILED = { "NV200101", "Error occured when Download Vehicle Template." };
        public static readonly string[] DOWNLOAD_CUSTOMER_TEMPLATE_FAILED = { "NV200102", "Error occured when Download Customer Template." };
        public static readonly string[] INDEX_FAILED = { "NV200103", "Error occured when Index." };
        public static readonly string[] ADD_CANCELLATION_RULE_FAILED = { "NV200104", "Error occured when Add Cancellation Rule." };
        public static readonly string[] GET_ALL_CANCELLATION_RULE_FAILED = { "NV200105", "Error occured when Get all Cancellation Rule." };
        public static readonly string[] DELETE_CANCELLATION_RULE_FAILED = { "NV200106", "Error occured when Delete Cancellation Rule." };
        public static readonly string[] EDIT_CANCELLATION_RULE_FAILED = { "NV200107", "Error occured when Edit Cancellation Rule." };
        public static readonly string[] UPDATE_CANCELLATION_RULE_FAILED = { "NV200108", "Error occured when Update Cancellation Rule." };
        public static readonly string[] FEATURES_FAILED = { "NV200109", "Error occured when Features." };
        public static readonly string[] GET_CLIENTS_FAILED = { "NV200110", "Error occured when Get clients." };
        public static readonly string[] MANAGE_FEATURE_FAILED = { "NV200111", "Error occured when Manage feature." };
        public static readonly string[] EDIT_FEATURES_FAILED = { "NV200112", "Error occured when Edit Features." };
        public static readonly string[] ADD_CLIENTS_FEATURE_FAILED = { "NV200113", "Error occured when Add clients feature." };
        public static readonly string[] DELETE_FEATURES_FAILED = { "NV200114", "Error occured when Delete Features." };
        public static readonly string[] MANAGE_CLIENT_FEATURES_FAILED = { "NV200115", "Error occured when Manage client Features." };
        public static readonly string[] GET_ALL_CLIENT_FEATURES_FAILED = { "NV200116", "Error occured when Get All Client Features." };
        public static readonly string[] GET_ALL_CLIENT_INVOICE_ITEM_FAILED = { "NV200117", "Error occured when Get All Client Invoice Items." };
        public static readonly string[] GET_MESSAGE_BY_ID_FAILED = { "NV200118", "Error occured when Get Message by id." };
        public static readonly string[] EDIT_POPUP_FAILED = { "NV200119", "Error occured when Edit popup." };
        public static readonly string[] UPDATE_MESSAGE_FAILED = { "NV200120", "Error occured when Update Message." };
        public static readonly string[] DELETE_MESSAGE_FAILED = { "NV200121", "Error occured when Delete Message." };
        public static readonly string[] ADD_POPUP_FAILED = { "NV200122", "Error occured when Add popup." };
        public static readonly string[] CREATE_CLIENT_MESSAGE_FAILED = { "NV200123", "Error occured when Create Client Message." };
        public static readonly string[] EDIT_CLIENT_INVOICE_ITEM_FAILED = { "NV200124", "Error occured when Edit client invoice item." };
        public static readonly string[] UPDATE_SETTING_FAILED = { "NV200125", "Error occured when Update setting." };
        public static readonly string[] MANAGE_CLIENT_RESERVATION_MODULE_FAILED = { "NV200126", "Error occured when Manage Client Reservation Module." };
        public static readonly string[] GET_MONTH_LIST_FAILED = { "NV200127", "Error occured when Get month list." };
        public static readonly string[] GET_YEAR_LIST_FAILED = { "NV200128", "Error occured when Get year list." };
        public static readonly string[] LOAD_REPORT_FAILED = { "NV200129", "Error occured when Load Report." };
        public static readonly string[] CONVERT_TO_DIRECTIONARY_FAILED = { "NV200127", "Error occured when Convert To Dictionary." };
        public static readonly string[] MANAGE_COLLECTOR_FAILED = { "NV200130", "Error occured when Manage Collector." };
        public static readonly string[] ADD_COLLECTOR_FAILED = { "NV200131", "Error occured when Add Collector." };
        public static readonly string[] CONFIRM_COLLECTOR_FAILED = { "NV200132", "Error occured when Confirm Collector." };
        public static readonly string[] GET_ALL_COLLECTOR_FAILED = { "NV200133", "Error occured when Get all Collector." };
        public static readonly string[] DELETE_COLLECTOR_FAILED = { "NV200134", "Error occured when Delete Collector." };
        public static readonly string[] ADMINISTRATOR_FAILED = { "NV200135", "Error occured when Administratorr." };
        public static readonly string[] GET_ALL_VEHICLE_MAKES_FAILED = { "NV200136", "Error occured when Get All Vehicle Make." };
        public static readonly string[] GET_COMPANY_EXPENSE_BY_ID_FAILED = { "NV200137", "Error occured when Get Company Expense By ID." };
        public static readonly string[] GET_ALL_COMPANY_EXPENSE_TYPE_FAILED = { "NV200138", "Error occured when Get all Company Expense type." };
        public static readonly string[] GET_ALL_EXPENSES_FAILED = { "NV200139", "Error occured when Get all Expenses." };
        public static readonly string[] EXPENSE_TYPE_FAILED = { "NV200140", "Error occured when Expense type." };
        public static readonly string[] RELOAD_GRID_FAILED = { "NV200141", "Error occured when Reload Grid." };
        public static readonly string[] MANAGE_VEHICLE_EXPENSE_FAILED = { "NV200142", "Error occured when Manage Vehicle Expense." };
        public static readonly string[] SEARCH_VEHICLE_EXPENSE_FAILED = { "NV200143", "Error occured when search Vehicle Expense." };
        public static readonly string[] DELETE_VEHICLE_EXPENSE_FAILED = { "NV200144", "Error occured when Delete Vehicle Expense." };
        public static readonly string[] EDIT_VEHICLE_EXPENSE_FAILED = { "NV200145", "Error occured when Edit Vehicle Expense." };
        public static readonly string[] UPDATE_VEHICLE_EXPENSES_FAILED = { "NV200146", "Error occured when Update Vehicle Expense." };
        public static readonly string[] EDIT_FAILED = { "NV200147", "Error occured when Edit." };
        public static readonly string[] DELETE_FAILED = { "NV200148", "Error occured when Delete." };
        public static readonly string[] ADD_COMPANY_EXPENSE_ITEM_FAILED = { "NV200149", "Error occured when Add Company Expense Item." };
        public static readonly string[] MANAGE_COMPANY_EXPENSE_ITEM_FAILED = { "NV200150", "Error occured when Manage Company Expense Item." };
        public static readonly string[] GET_ALL_COMPANY_EXPENSE_ITEM_FAILED = { "NV200151", "Error occured when Get all Company Expense Item." };
        public static readonly string[] MANAGE_CURRENCY_CONVERTER_FAILED = { "NV200152", "Error occured when Manage Currency Converter." };
        public static readonly string[] CURRENCY_LIST_FAILED = { "NV200153", "Error occured when Currency List." };
        public static readonly string[] ADD_CREDIT_NOTE_FAILED = { "NV200154", "Error occured when Add Credit Note." };
        public static readonly string[] ADD_CREDIT_NOTE_ITEM_VIEWPOPUP_FAILED = { "NV200155", "Error occured when Add Credit Note Item ViewPopup." };
        public static readonly string[] ADD_CREDIT_NOTE_ITEM_FAILED = { "NV200156", "Error occured when Add Credit Note Item." };
        public static readonly string[] DELETE_CREDIT_NOTE_FAILED = { "NV200157", "Error occured when Delete Credit Note." };
        public static readonly string[] DELETE_CREDIT_NOTE_ITEM_FAILED = { "NV200158", "Error occured when Delete Credit Note Item." };
        public static readonly string[] GET_CREDIT_NOTE_ITEM_DETAILS_FAILED = { "NV200159", "Error occured when Get Credit Note ITem Details." };
        public static readonly string[] GET_CREDIT_NOTE_ITEM_BY_ID_FAILED = { "NV200160", "Error occured when Get Credit Note Item By Id." };
        public static readonly string[] PRINT_CREDIT_NOTES_URL_FAILED = { "NV200161", "Error occured when Print Credit Notes Url." };
        public static readonly string[] PRINT_CREDIT_NOTES_FAILED = { "NV200162", "Error occured when Print Credit Notes." };
        public static readonly string[] GET_CONVERSION_BT_ID_FAILED = { "NV200163", "Error occured when Get Conversion By Id." };
        public static readonly string[] CONVERTION_LIST_FAILED = { "NV200164", "Error occured when Conversion List." };
        public static readonly string[] ADD_EDIT_CONVERTION_FAILED = { "NV200165", "Error occured when Add Edit Conversion." };
        public static readonly string[] GET_CURRENCY_CONCERTION_HISTORY_FAILED = { "NV200166", "Error occured when Get Currency Conversion History." };
        public static readonly string[] CHECK_CONVERTION_AVAILABILITY_FAILED = { "NV200167", "Error occured when Check Conversion Availability." };
        public static readonly string[] DISPLAY_IMAGE_FAILED = { "NV200168", "Error occured when Display Image." };
        public static readonly string[] UPDATE_CUSTOMER_FAILED = { "NV200169", "Error occured when Update Customer." };
        public static readonly string[] UPDATE_SAVE_AGREEMENT_CUSTOMER_FAILED = { "NV200170", "Error occured when Update Save Agreement Customer." };
        public static readonly string[] UPDATE_AGREEMENT_CUSTOMER_FAILED = { "NV200171", "Error occured when Update Agreement Customer." };
        public static readonly string[] ADD_AGREEMENT_CUSTOMER_FAILED = { "NV200172", "Error occured when Add Agreement Customer." };
        public static readonly string[] ADD_EDIT_CUSTOMER_FAILED = { "NV200173", "Error occured when Add Edit Customer." };
        public static readonly string[] ADD_CREDIT_CARD_FAILED = { "NV200174", "Error occured when Add Credit Card." };
        public static readonly string[] ADD_NOTE_FAILED = { "NV200175", "Error occured when Add Note." };
        public static readonly string[] EDIT_CREDIT_CARD_FAILED = { "NV200176", "Error occured when Edit Credit Card." };
        public static readonly string[] EDIT_NOTE_FAILED = { "NV200177", "Error occured when Edit Note." };
        public static readonly string[] UPDATE_CREDIT_CARD_FAILED = { "NV200178", "Error occured when Update Credit Card." };
        public static readonly string[] UPDATE_NOTE_FAILED = { "NV200179", "Error occured when Update Note." };
        public static readonly string[] UPDATE_CREDIT_CARD_DETAILS_FAILED = { "NV200180", "Error occured when Update Credit Card Details." };
        public static readonly string[] DELETE_CUSTOMER_FAILED = { "NV200181", "Error occured when Delete customer." };
        public static readonly string[] DELETE_CREDIT_CARD_FAILED = { "NV200182", "Error occured when Delete Credit Card." };
        public static readonly string[] DELETE_NOTE_FAILED = { "NV200183", "Error occured when Delete note." };
        public static readonly string[] LOAD_AGREEMENT_CUSTOMER_FAILED = { "NV200184", "Error occured when Load Agreement Customer." };
        public static readonly string[] CUSTOMER_REVIEW_GRID_FAILED = { "NV200185", "Error occured when Customer Review Grid" };
        public static readonly string[] GRID_FOR_NOTE_FAILED = { "NV200186", "Error occured when loading Grid For Note" };
        public static readonly string[] VALIDATE_DRIVER_FAILED = { "NV200187", "Error occured when Validating Driver" };
        public static readonly string[] VIEW_DEPOSIT_HISTORY_FAILED = { "NV200188", "Error occured when Viewing Deposit History" };
        public static readonly string[] MANAGE_CUSTOMER_FAILED = { "NV200189", "Error occured when Managing Customer" };
        public static readonly string[] GET_ALL_CUSTOMER_FAILED = { "NV200190", "Error occured when Getting All Customer" };
        public static readonly string[] GET_CUS_LIST_FAILED = { "NV200190", "Error occured when Getting Cus List" };
        public static readonly string[] EXPORT_EXCEL_SHEET_CUSTOMER_SEARCH_FAILED = { "NV200191", "Error occured when Exporting Excel Customer Search" };
        public static readonly string[] GET_CUSTOMER_BY_ID_FAILED = { "NV200192", "Error occured when Getting Customer By ID" };
        public static readonly string[] IS_VIEW_CARD_NUMBER_FAILED = { "NV200193", "Error occured when Getting View Card Number" };
        public static readonly string[] COUNTRY_FOR_ADD_FAILED = { "NV200194", "Error occured when Getting View Card Number" };
        public static readonly string[] STATE_FAILED = { "NV200195", "Error occured when Retreiving State" };
        public static readonly string[] GET_DAMAGE_TYPE_FAILED = { "NV200196", "Error occured when Retreiving Damage Type" };
        public static readonly string[] VECHILE_DAMAGE_MAPPING_FAILED = { "NV200197", "Error occured when Mapping Vehicle Damage" };
        public static readonly string[] ATTACHMENT_DAMAGE_MAPPING_FAILED = { "NV200197", "Error occured when Mapping Attchment" };
        public static readonly string[] VEHICLE_DAMAGE_MODEL_MAPPING_FAILED = { "NV200198", "Error occured when Mapping Vehicle Damage Model" };
        public static readonly string[] ATTACHMENT_DAMAGE_MODEL_MAPPING_FAILED = { "NV200199", "Error occured when Mapping Attachment Damage Model" };
        public static readonly string[] CHECK_CORDINATE_FAILED = { "NV200200", "Error occured when checking Cordinate" };
        public static readonly string[] ADD_VEHICLE_DAMAGE_IMAGE_FAILED = { "NV200201", "Error occured when Adding Vehicle Damage Image" };
        public static readonly string[] GET_VALUES_FAILED = { "NV200202", "Error occured when getting Values" };
        public static readonly string[] GET_DAMAGE_BY_ID_FAILED = { "NV200203", "Error occured when getting Damage By ID" };
        public static readonly string[] MANAGE_DAMAGE_FAILED = { "NV200204", "Error occured when Managing Damage" };
        public static readonly string[] LIST_DAMAGE_FAILED = { "NV200205", "Error occured when Listing Damage" };
        public static readonly string[] DELETE_VEHICLE_DAMAGES_FAILED = { "NV200206", "Error occured when Deleting Vehicle" };
        public static readonly string[] FILL_DAMAGE_GRID_FAILED = { "NV200207", "Error occured when Filling Damage Grid" };
        public static readonly string[] ADD_DAMAGES_FAILED = { "NV200208", "Error occured when Adding Damages" };
        public static readonly string[] MANAGE_DAMAGE_REPORT_FAILED = { "NV200209", "Error occured when Mangaging Damage Report" };
        public static readonly string[] PREVIEW_DAMAGE_REPORT_DETAILS_FAILED = { "NV200210", "Error occured when Previewing Damage Report Details" };
        public static readonly string[] PREVIEW_SECONDARY_DAMAGE_DETAILS_FAILED = { "NV200211", "Error occured when Previewing Secondary Damage Report Details" };
        public static readonly string[] GET_COORDINATE_VALUES_FAILED = { "NV200212", "Error occured when retrieving Coordinate Values" };
        public static readonly string[] DAMAGE_LIST_FAILED = { "NV200213", "Error occured when retrieving Damange List" };
        public static readonly string[] VIEW_REPORT_FAILED = { "NV200214", "Error occured when Viewing Report" };
        public static readonly string[] VIEW_REPORT_LIST_FAILED = { "NV200215", "Error occured when Viewing Report List" };
        public static readonly string[] GET_COORDINATE_VALUE_FOR_REPORT_FAILED = { "NV200216", "Error occured when Retreiving Coordinate Value For Report" };
        public static readonly string[] PRINT_REPORT_FAILED = { "NV200217", "Error occured when Printing Report" };
        public static readonly string[] CHECK_LIST_IN_POPUP_FAILED = { "NV200218", "Error occured when Check List in PopUp" };
        public static readonly string[] GET_QUESTION_COUNT_FAILED = { "NV200219", "Error occured Retrieving Question Count" };
        public static readonly string[] SUBMIT_CHECK_LIST_FAILED = { "NV200220", "Error occured when Checking List" };
        public static readonly string[] CHECK_LIST_OUT_POPUP_FAILED = { "NV200221", "Error occured when Check List out in Popup" };
        public static readonly string[] CHECK_LIST_FOR_PRINT_FAILED = { "NV200222", "Error occured when Check List for Print" };
        public static readonly string[] SAVE_DAMAGE_IMAGE_FAILED = { "NV200223", "Error occured when Saving Damage Image" };
        public static readonly string[] GET_RATE_NAMES_BY_LOCATION_FAILED = { "NV200224", "Error occured while retrieving Rate Names by Location" };
        public static readonly string[] GET_VEHICLE_BY_LICENSE_NUMBER_FAILED = { "NV200225", "Error occured while retrieving Vehicle License Number" };
        public static readonly string[] GET_CURRENT_STATISTICS_FAILED = { "NV200226", "Error occured while retrieving Current Statistics" };
        public static readonly string[] VIEW_ADMIN_MESSAGES_FOR_CLIENT_FAILED = { "NV200227", "Error occured while viewing Admin Messages For Client" };
        public static readonly string[] GET_CUSTOMER_BY_CREDIT_CARD_FAILED = { "NV200228", "Error occured while retrieving Customer by Credit Card" };
        public static readonly string[] GET_CUSTOMER_BY_PHONE_NO_FAILED = { "NV200229", "Error occured while retrieving Customer by Phone Number" };
        public static readonly string[] GET_RESERVATION_BY_RESERVATION_ID_FAILED = { "NV200230", "Error occured while retrieving Reservation by Reservation ID" };
        public static readonly string[] GET_AGREEMENT_DETAILS_FAILED = { "NV200231", "Error occured while retrieving Agreement Details" };
        public static readonly string[] GET_VECHICLE_DETAILS_BY_VEHICLE_NUMBER_FAILED = { "NV200232", "Error occured while retrieving Agreement Details" };
        public static readonly string[] GET_QUICK_RESERVATION_FAILED = { "NV200233", "Error occured while retrieving Quick Reservation" };
        public static readonly string[] GET_VEHICLE_STATUS_DATE_FAILED = { "NV200234", "Error occured while retrieving Status Date" };
        public static readonly string[] GET_PICKUPS_FAILED = { "NV200235", "Error occured while retrieving Pickups" };
        public static readonly string[] GET_SALES_STATUS_DATA_FAILED = { "NV200236", "Error occured while retrieving Sales Status Data" };
        public static readonly string[] VIEW_ALERTS_FAILED = { "NV200237", "Error occured while Viewing Alerts" };
        public static readonly string[] VIEW_ALERTS_BY_TYPE_FAILED = { "NV200238", "Error occured while Viewing Alerts By Type" };
        public static readonly string[] GET_CURRENT_PAYMENT_DELAYS_FAILED = { "NV200239", "Error occured while retrieving Current payment Delays" };
        public static readonly string[] TODO_FAILED = { "NV200240", "Error occured while Viewing TODO" };
        public static readonly string[] GET_TODO_FAILED = { "NV200241", "Error occured while retrieving TODO" };
        public static readonly string[] SEARCH_TODO_FAILED = { "NV200242", "Error occured while searching TODO" };
        public static readonly string[] ADD_TODO_FAILED = { "NV200243", "Error occured while Adding TODO" };
        public static readonly string[] MARK_TODO_FAILED = { "NV200244", "Error occured while Marking TODO" };
        public static readonly string[] DELETE_TODO_FAILED = { "NV200245", "Error occured while Marking TODO" };
        public static readonly string[] UPDATE_EXPIRY_DATE_FAILED = { "NV200246", "Error occured while Marking TODO" };
        public static readonly string[] GET_ARRIVALS_FAILED = { "NV200247", "Error occured while retrieving Arrivals" };
        public static readonly string[] GET_VEHICLES_FAILED = { "NV200248", "Error occured while retrieving Vehicles" };
        public static readonly string[] GET_RESERVATION_TEMPLATE_FAILED = { "NV200249", "Error occured while retrieving Reservation Templates" };
        public static readonly string[] INSERT_FAILED = { "NV200250", "Error occured when Add." };

        #endregion
    }

    public static class AppConstants
    {
        public static string BUSINESS_LAYER_POLICY = "BusinessLayerPolicy";
        public static string AUTHORIZATION_POLICY = "AuthorizationPolicy";
        public static string PRESENTATION_LAYER_POLICY = "PresentationLayerPolicy";
        public static string DATA_LAYER_POLICY = "DataLayerPolicy";
    }

    public enum FunctionKey
    {
        BackgroundProcessOverride = 0,

        //?????????????????????????????????
        UPDATE_VEHICLEMODEL = 10,
        UPDATE_VEHICLE_OPTION = 15,
        UPDATE_VEHICLE_DETAILS = 51,
        UPDATE_TAX_DETAILS = 57,
        GET_ALL_INQUIRIES = 122,
        EDIT_INQUIRY = 123,
        GET_INQUIRY_BY_ID = 124,
        ADD_INQUIRY = 125,
        GET_ALL_INQUIRY_ITEMS = 126,
        GET_ALL_CONVICTIONS = 127,
        ADD_INQUIRY_ITEM = 128,
        ADMINISTRATORMENU = 134,
        SEARCH_MIS_LOCATION_CHARGE = 85,
        GET_MISCHARGE_FOR_LOCATION = 80,
        MAKE_SERVICES = 5,
        EDIT_MAKE = 8,
        GET_VEHICLE_MAKE = 44,
        ADD_RATES = 102,
        GET_ALL_REFERRAL = 56,
        GET_RATES_FOR_LOCATION = 101,
        GET_RATE_TYPES = 100,
        GET_ALLINSURANCE_COMPANIES = 42,
        ADD_LOCATION_OPTION = 94,
        EDIT_MISCHARGE_OPTION = 89,
        GET_ALL_MISCHARGE_OPTION = 86,
        GET_MISCHARGE_OPTION_BY_ID = 81,
        EDIT_MISCHARGE_TYPE = 83,
        INSERT_MISCHARGE_DETAILS = 84,
        //GET_ALL_VEHICLE_MAKE = 118,
        GET_ALL_VEHICLE_MODEL = 119,
        GET_ALL_LEASING_COMPANY = 36,
        GET_COUNTRY = 25,
        GET_VEHICLE_BY_ID = 120,
        GET_ALL_VEHICLES = 117,
        GET_TAX_BY_ID = 67,
        GET_VEHICLEMODEL_NAMES_BY_MAKE = 12,
        GET_VEHICLEMODEL_BY_MAKE = 13,
        GET_ALL_VEHICLE_TYPES = 6,
        GET_VEHICLE_TYPE_BY_ID = 30,
        GET_VEHICLE_TYPE_BY_Vehicle_ID = 32,
        GET_VEHICLE_TYPE_IMAGE = 33,
        INSERT_VEHICLEOPTION_MAPPING = 19,
        GET_ALL_LOCATION = 23,
        GET_COMPANY_EXPENSE_BY_CLIENT_ID = 75,
        GET_COMPANY_EXPENSE_ITEM_BY_ID = 76,
        GET_ALL_MISCHARGE_TYPE = 87,
        GET_MISCHARGE_TYPE_BY_ID = 82,
        UPDATE_COMPANY_EXPENSE = 95,
        GET_COMPANY_EXPENSE_TYPES = 108,


        DASHBOARDMENU = 135,
        GET_STATE = 26,
        DELETE_LEASING_COMPANY = 35,
        DELETE_RATES = 104,
        DELETE_SEASON_RATE_BY_ID = 59,
        DELETE_USER = 2,
        DELETE_VEHICLEMODEL = 11,
        DELETE_VEHICLES = 115,
        DELETE_MISCHARGE_DETAILS = 92,
        DELETE_MISCHARGE_OPTION = 91,
        DELETE_INSURANCE_COMPANY = 40,
        DELETE_INQUIRY_ITEM = 129,
        DELETE_VEHICLEOPTION_MAPPING = 20,

        //-------------------------------------------///
        //ADD_NEW_VEHICLES = 1,
        INSERT_VEHICLE = 1,
        VIEW_CAR_RESERVATION_PAGE = 2,
        VIEW_CUSTOMER_SEARCH_PAGE = 3,
        VIEW_VEHICLE_MANAGE_PAGE = 4,
        GET_ALL_VEHICLE_MAKES = 5,
        //GET_ALL_VEHICLE_TYPE = 6,
        ADD_NEW_CUSTOMER = 7,
        VIEW_ADD_VEHICLE_PAGE = 8,
        GET_LOCATIONS = 9,
        GET_LOCATIONS_STATE_ID = 10,
        SEARCH_RESERVATIONS = 11,
        UPDATE_VEHICLES = 12,
        GET_VEHICLE = 13,
        SEARCH_VEHICLE = 14,
        UPDATE_CUSTOMER = 15,
        SEARCH_CUSTOMER = 21,
        ADD_RESERVATION = 18,
        GET_VEHICLE_IMAGE = 19,
        SAVE_VEHICLE_IMAGE = 20,
        SEARCH_AVAILABLE_VEHICLES = 22,
        GET_VEHICLE_MODELS_FOR_MAKE = 23,
        VIEW_AGREEMENT_SEARCH = 24,
        SEARCH_AGREEMENT = 25,
        GET_ALL_LEASING_COMPANIES = 26,
        GET_ALL_INSURANCE_COMPANIES = 27,
        VIEW_LOCATION_MANAGE_PAGE = 28,
        VIEW_RATES_MANAGE_PAGE = 29,
        VIEW_ADMINISTRATION_PAGE = 30,
        ADD_LOCATION = 31,
        ADD_RATE = 32,
        GET_LOCATION_BY_ID = 33,
        UPDATE_LOCATION = 34,
        //EDIT_LOCATION = 34,
        GET_DRIVERS_BY_AGREEMENTID = 35,
        ADD_NEW_DRIVER = 36,
        UPDATE_DRIVER = 37,
        VIEW_DRIVER = 38,
        GET_ALL_RATES = 39,
        //GET_ALL_LOCATIONRATES = 39,
        UPDATE_RATE = 40,
        GET_VEHICLE_MODEL = 41,
        VIEW_MAKE_MANAGE_PAGE = 42,
        //ADD_EXPENSE = 43,
        ADD_NEW_EXPENSE = 43,
        SEARCH_EXPENSE = 44,
        UPDATE_EXPENSE = 45,
        VIEW_ADD_EXPENSE_PAGE = 46,
        VIEW_MANAGE_EXPENSE_PAGE = 47,
        VIEW_SUMMARY = 48,
        SAVE_VEHICLE_MAKE = 49,
        //ADD_MAKE = 49,
        SAVE_VEHICLE_MODEL = 50,
        VIEW_AGREEMENT = 51,
        VIEW_TAX_PAGE = 52,
        VIEW_ADD_TAX_PAGE = 53,
        //ADD_NEW_TAX = 54,
        ADD_TAX_LOC = 54,
        GET_ALL_TAX = 55,
        SEARCH_TAX_BY_LOCATION = 56,
        UPDATE_TAX = 57,
        DELETE_TAX = 58,
        VIEW_REPORTS = 59,
        VIEW_MISCCHARGE_PAGE = 60,
        VIEW_ADD_MISCCHARGE_PAGE = 61,
        //ADD_NEW_MISCCHARGE = 62,
        ADD_LOCATION_MISCHARGE = 62,
        GET_ALL_MISCCHARGE = 63,
        SEARCH_MISCCHARGE = 64,
        UPDATE_MISCCHARGE = 65,
        DELETE_MISCCHARGE = 66,
        //GET_MISCCHARGE_FOR_LOCATION = 67,
        GET_ALL_MISCHARGE_FOR_LOCATIONID = 67,
        UPDATE_RESERVATION = 68,
        GET_VEHICLE_OPTION = 69,
        ADD_AGREEMENT_INSURENCE = 70,
        UPDATE_AGREEMENT_INSURENCE = 71,
        VIEW_AGREEMENT_INSURENCE = 72,
        VIEW_VEHICLE_TYPE_MANAGE_PAGE = 73,
        //SAVE_VEHICLE_TYPE = 74,
        SAVE_VEHICLE_TYPE = 74,
        SAVE_FULL_RESERVATION = 75,
        PRINT_AGREEMENT = 76,
        VIEW_REFERRAL_NAMES = 77,
        VIEW_REFERRAL_DETAILS = 78,
        VIEW_VEHICLE_DAMAGE_REPORT = 79,
        SAVE_VEHICLE_DAMAGE = 80,
        GET_ALL_DAMAGE_DETAILS_FOR_VEHICLE = 81,
        DELETE_AGREEMENT = 82,

        ADD_TRAFFIC_TICKET = 83,
        UPDATE_TRAFFIC_TICKET = 84,
        GET_TRAFFIC_TICKET_BY_ID = 85,
        VIEW_TRAFFIC_TICKET = 86,
        PENDING_PAYMENT = 87,

        ADD_LEASING_COMPANY = 88,
        //UPDATE_LEASING_COMPANY = 89,
        UPDATE_LEASING_COMPANY = 89,
        GET_LEASING_COMPANY_BY_ID = 90,
        VIEW_LEASING_COMPANY = 91,
        SEARCH_LEASING_COMPANYS = 92,

        ADD_INSURANCE_COMPANY = 93,
        UPDATE_INSURANCE_COMPANY = 94,
        //GET_INSURANCE_COMPANY_BY_ID = 95,
        GET_INSURANCE_COMPANY_BY_ID = 95,
        VIEW_INSURANCE_COMPANY = 96,
        SEARCH_INSURANCE_COMPANYS = 97,

        VIEW_VEHICLE_EXCHANGE = 98,
        EXCHANGE_VEHICLE = 99,

        ADD_USER = 100,
        //UPDATE_USER = 101,
        EDIT_USER = 101,
        GET_USER_BY_ID = 102,
        VIEW_USER = 103,
        SEARCH_USERS = 104,
        RESET_USER_PASSWORD = 105,
        GET_USER_ROLE_NAME = 106,

        ADD_REFERRAL = 107,
        //UPDATE_REFERRAL = 108,
        EDIT_REFERRAL = 108,
        GET_REFERRAL_BY_ID = 109,
        VIEW_REFERRAL = 110,
        SEARCH_REFERRALS = 111,

        UDDATE_AGREEMENT_NOTE = 112,
        DELETE_AGREEMENT_NOTE = 113,

        ADD_INVOICE = 114,
        ADD_PAYMENT = 115,
        VIEW_INVOICE_PAYMENT = 116,
        UPDATE_INVOICE = 117,
        UPDATE_PAYMENT = 118,
        DELETE_INVOICE = 119,
        DELETE_PAYMENT = 120,
        GET_INVOICE = 121,

        GET_PAYMENT = 122,

        ADD_COMPANY_EXPENSE = 123,
        ADD_COMPANY_EXPENSE_ITEM = 124,
        GET_ALL_COMPANY_EXPENSE = 125,
        //GET_ALL_COMPANY_EXPENSE_ITEM = 126,
        GET_ALL_COMPANY_EXPENSE_ITEM = 126,
        DELETE_COMPANY_EXPENSE = 127,
        DELETE_COMPANY_EXPENSE_ITEM = 128,
        GET_COMPANY_EXPENSE = 129,
        GET_COMPANY_EXPENSE_ITEM = 130,
        EDIT_COMPANY_EXPENSE = 131,
        //EDIT_COMPANY_EXPENSE_ITEM = 132,
        UPDATE_COMPANY_EXPENSE_ITEM = 132,

        SHOW_VEHICLE_SALES_REPORT = 133,
        DELETE_VEHICLE_MAKE = 134,
        DELETE_VEHICLE_MODEL = 135,
        DELETE_VEHICLE_TYPE = 136,
        CREATE_NEW_CLIENT = 137,
        GET_FEATURE_FOR_CLIENT = 138,
        VIEW_VEHICLE_OPTION_MANAGE_PAGE = 139,
        SAVE_VEHICLE_OPTION = 140,
        //ADD_VEHICLE_OPTION = 140,
        DELETE_VEHICLE_OPTION = 141,
        VIEW_RESERVATION_REPORT = 142,
        ADD_AGREEMENT_PAGE = 143,
        RESERVATION_ADD_PAGE = 144,
        ADD_DRIVER_PAGE = 145,
        ADD_EXPENSE_PAGE = 146,
        ADD_MISCCHARGE_PAGE = 147,
        ADD_MISCCHARGE_OPTION_PAGE = 148,
        ADD_VEHICLE_PAGE = 149,
        ADD_VEHICLE_REPLACE_PAGE = 150,
        VIEW_AGREEMENT_DETAILS_PAGE = 151,
        AGREEMENT_SEARCH_PRINT_PREVIEW_PAGE = 152,
        CAR_RESERVATIONS_PRINT_PREVIEW_PAGE = 153,
        CHECKIN_AGREEMENT_PAGE = 154,
        CHECKOUT_AGREEMENT_PAGE = 155,
        CUSTOMER_REVIEW_PAGE = 156,
        ADD_NEW_CUSTOMER_PAGE = 157,
        PRINT_VEHICLE_DAMAGE_REPORT_PAGE = 158,
        VIEW_LANDING_PAGE = 159,
        VIEW_MISCCHARGE_OPTION_PAGE = 160,
        VIEW_MANAGE_MODEL_PAGE = 161,
        VIEW_MANAGE_RESERVATION_MODULE_PAGE = 162,
        VIEW_MANAGE_STORE_HOURS_PAGE = 163,
        VIEW_MARKUP_PAGE = 164,
        VIEW_QUICK_QUOTE_PAGE = 165,
        VIEW_RESERVATION_CONFIRM_PAGE = 166,
        VIEW_RESERVATION_DETAIL_PAGE = 167,
        VIEW_RESERVATION_SUMMARY_PAGE = 168,
        VIEW_RESERVATION_VEHICLE_TYPE_SUMMARY_REPORT = 169,
        VIEW_RESET_PASSWORD_PAGE = 170,
        VIEW_SPLIT_BILLING_PAGE = 171,
        VIEW_TODO_TASKS_PAGE = 172,
        VIEW_TOLL_SUMMARY_REPORT_PAGE = 173,
        VIEW_USER_REVIEW_PAGE = 174,
        VIEW_VEHICLE_DAMAGE_PAGE = 175,
        VIEW_VEHICLE_REVIEW_PAGE = 176,
        VIEW_VEHICLE_SEARCH_PAGE = 177,
        SAVE_VEHICLE = 178,
        GET_VEHICLE_TYPE = 179,
        VEHICLE_EXIST = 180,
        GET_ALL_DAMAGE_DETAILS_FOR_AGREEMENT = 181,
        GET_ALL_EXPENSE_TYPE = 182,
        GET_VEHICLE_OPTIONS = 183,
        SEARCH_AVAILABLE_VEHICLES_FOR_RESERVATION = 184,
        RESET_PASSWORD = 185,
        SEARCH_USER = 186,
        MAX_USER = 187,
        SEARCH_TRAFFIC_TICKET = 188,
        GET_RESERVATION = 189,
        //***
        GET_RESERVATION_SUMMARY = 190,
        GET_VEHICLE_TYPE_RESERVATION_SUMMARY = 191,
        GET_RESERVATION_PICKUP = 192,
        GET_RETURN_VEHICLE = 193,
        GET_LEASE_EXPIRE = 194,
        CANCEL_RESERVATION = 195,
        GET_RATE_BY_ID = 196,
        DELETE_RATE = 197,
        SEARCH_RATES = 198,
        GET_RATE_DETAILS = 199,
        GET_TAXES_FOR_LOCATION = 200,
        GET_ALL_COUNTRY_ID = 201,
        GET_ALL_STATE_ID = 202,
        GET_DRIVER_TYPE_LIST = 203,
        ADD_DRIVER_LICENSE_CHECK = 204,
        SEARCH_VEHICLE_RESERVATION = 205,
        SAVE_CUSTOMER_CREDIT_CARD = 206,
        SAVE_CUSTOMER_ADDRESS = 207,
        DELETE_CUSTOMER_ADDRESS = 208,
        DELETE_CUSTOMER_CREDIT_CARD = 209,
        GET_CURRENT_STATISTICS = 210,
        SEARCH_TOLL_DETAIL = 211,
        ADD_TOLL_HEADER = 212,
        UPDATE_CLIENT = 213,
        GET_ALL_CLIENT = 214,
        GET_CLIENT_DETAIL = 215,
        ADD_TOLL_DETAIL = 216,
        UPDATE_TOLL_DETAIL = 217,
        GET_CHART_DATASOURCE = 218,
        GET_FEATURE_ATTRIBUTE_FOR_CLIENT = 219,
        ADD_INVOICE_ITEM = 220,
        NEXT_OIL_CHANGE = 221,
        ADD_AGREEMENT = 222,
        UPDATE_AGREEMENT = 223,
        CHECK_IN_AGREEMENT = 224,
        PENDING_PAYMENT_AGREEMENT = 225,
        CHECK_OUT_AGREEMENT = 226,
        ADD_VEHICLE_EXCHANGE = 227,
        ADD_NEW_MISCCHARGE_OPTION = 228,
        GET_ALL_STORE_HOURS = 229,
        GET_ALL_MISCCHARGE_OPTION = 230,
        UPDATE_RESERVATION_MODULE = 231,
        GET_RESERVATION_MODULE = 232,
        UDDATE_STORE_HOURS = 233,
        UPDATE_INVOICE_ITEM = 234,
        GET_INVOICE_ITEM = 235,
        VIEW_MANAGE_CLIENT_FEATURES = 236,
        DELETE_CLIENT_FEATURE = 237,
        //GET_CLIENT_FEATURE_DETAIL = 238,
        GET_CLIENT_FEATURE_BY_ID = 238,
        EDIT_CLIENT_FEATURE = 239,
        GET_ALL_CLIENT_FEATURE = 240,
        ADD_CLIENT_FEATURE = 241,
        UPLOAD_DOCUMENTS = 242,
        ADD_DOCUMENT = 243,
        GET_CLIENT_DOCUMENTS = 244,
        DELETE_DOCUMENT = 245,
        GET_USED_FILE_SIZE = 246,
        GET_MAX_FILE_SIZE = 247,
        PRINT_INVOICE_PAGE = 248,
        GET_SHARED_LOCATIONS = 249,
        ADD_SHARED_LOCATION = 250,
        DELETE_ALL_SHARED_LOCATIONS = 251,
        GET_LOCATION_BY_VEHICLE_ID = 252,
        GET_ALL_AGREEMENT_EQUIPMENT_TYPE = 253,
        GET_ALL_AGREEMENT_EQUIPMENT = 254,
        GET_AGREEMENT_EQUIPMENT_BY_ID = 255,
        ADD_AGREEMENT_EQUIPMENT = 256,
        EDIT_AGREEMENT_EQUIPMENT = 257,
        DELETE_AGREEMENT_EQUIPMENT = 258,
        GET_ALL_SEASON_RATE = 259,
        GET_SEASON_RATE_BY_ID = 260,
        ADD_SEASON_RATE = 261,
        //EDIT_SEASON_RATE = 262,
        UPDATE_SEASON_RATE = 262,
        DELETE_SEASON_RATE = 263,
        GET_ALL_VEHICLE_TRACK = 264,
        GET_VEHICLE_TRACK_BY_ID = 265,
        ADD_VEHICLE_TRACK = 266,
        EDIT_VEHICLE_TRACK = 267,
        DELETE_VEHICLE_TRACK = 268,
        COMPARE_AGREEMENT_HISTORY = 269,
        SEARCH_RESERVATION_REPORT = 270,
        UDDATE_VEHICLE_NOTE = 271,
        DELETE_VEHICLE_NOTE = 272,
        ADD_CUSTOMER_NOTE = 273,
        UPDATE_CUSTOMER_NOTE = 274,
        DELETE_CUSTOMER_NOTE = 275,
        GET_CUSTOMER_NOTE = 276,
        DELETE_RESERVATION = 277,
        GET_DOCUMENTS = 278,
        VIEW_DROPOFF_RATE_MANAGE_PAGE = 279,
        GET_ALL_VEHICLE_TYPES_FOR_RESERVATIONS = 280,
        VIEW_MANAGE_VEHICLE_RESERVATION_PAGE = 281,
        GET_MAX_VEHICLE_NUMBER = 282,
        //VIEW_VEHICLE_LIST = 283,
        GET_VEHICLE_LIST = 283,

        GET_DEPOSIT = 283,
        ADD_DEPOSIT = 284,
        UPDATE_DEPOSIT = 285,
        DELETE_DEPOSIT = 286,

        GET_PROMO_CODE = 287,
        ADD_PROMO_CODE = 288,
        UPDATE_PROMO_CODE = 289,
        DELETE_PROMO_CODE = 290,

        VIEW_INVOICE_SEARCH_PAGE = 291,

        CUSTOM_REPORT = 292,

        GET_SEQUENCE = 293,
        UPDATE_SEQUENCE = 294,
        GET_PAYMENT_GATEWAY_DETAILS = 295,

        GET_SERVICE_TYPE = 296,
        ADD_SERVICE_TYPE = 297,
        UPDATE_SERVICE_TYPE = 298,
        DELETE_SERVICE_TYPE = 299,
        GET_SERVICE_TYPE_BY_ID = 300,

        GET_VENDOR = 301,
        ADD_VENDOR = 302,
        UPDATE_VENDOR = 303,
        DELETE_VENDOR = 304,
        GET_VENDOR_BY_ID = 305,
        VIEW_MANAGE_SERVICE_TYPE_PAGE = 306,
        SAVE_SERVICE_TYPE = 307,

        GET_AUTHORIZED_EMP = 308,
        ADD_AUTHORIZED_EMP = 309,
        UPDATE_AUTHORIZED_EMP = 310,
        DELETE_AUTHORIZED_EMP = 311,
        GET_AUTHORIZED_EMP_BY_ID = 312,

        GET_PM_SERVICE_SETUP = 313,
        ADD_PM_SERVICE_SETUP = 314,
        UPDATE_PM_SERVICE_SETUP = 315,
        DELETE_PM_SERVICE_SETUP = 316,
        GET_PM_SERVICE_SETUP_BY_ID = 317,

        VIEW_AUTHORIZED_PAGE = 318,

        GET_SERVICE_TYPE_ITEM_SETUP = 319,
        ADD_SERVICE_TYPE_ITEM_SETUP = 320,
        UPDATE_SERVICE_TYPE_ITEM_SETUP = 321,
        DELETE_SERVICE_TYPE_ITEM_SETUP = 322,
        GET_SERVICE_TYPE_ITEM_BY_ID = 323,

        VIEW_MANAGE_SERVICE_ITEM_PAGE = 324,

        VIEW_MANAGE_VEHICLE_MAINTENANCE_PAGE = 325,
        GET_VEHICLE_MAINTENANCE = 326,
        GET_VEHICLE_MAINTENANCE_BY_ID = 327,
        ADD_VEHICLE_MAINTENANCE_SERVICE = 328,
        UPDATE_VEHICLE_MAINTENANCE_SERVICE = 329,
        DELETE_VEHICLE_MAINTENANCE_SERVICE = 330,

        VIEW_MANAGE_SERVICE_PAGE = 331,
        ADD_VEHICLE_SERVICE_ITEM = 332,
        UPDATE_VEHICLE_SERVICE_ITEM = 333,
        GET_VEHICLE_SERVICE_ITEM_BY_ID = 334,

        ADD_PAYMENT_GATEWAY_DETAILS = 335,
        UPDATE_PAYMENT_GATEWAY_DETAILS = 336,

        ADD_HOLIDAY = 337,
        UPDATE_HOLIDAY = 338,
        DELETE_HOLIDAY = 339,
        VIEW_HOLIDAY = 340,

        GET_CLIENTAPPSETTINGSBYCLIENTID = 341,
        DELETE_ALLVEHICLE_OPTION = 342,
        PAY_WITH_PAYPAL = 343,
        DELETE_LOCATION = 344,
        VIEW_ATTRIBUTES = 345,
        VIEW_LEDGER = 347,

        VIEW_MANAGE_VEHICLE_AVAILABILITY_PAGE = 348,
        GET_VEHICLE_AVAILABILITY = 349,
        GET_VEHICLE_AVAILABILITY_BY_ID = 350,
        ADD_VEHICLE_AVAILABILITY_SERVICE = 351,
        UPDATE_VEHICLE_AVAILABILITY_SERVICE = 352,
        DELETE_VEHICLE_AVAILABILITY_SERVICE = 353,


        //------------------V2 New Keys-----------------//
        ADMIN_EDIT_RATES = 1001,
        EDIT_CONTRACT_RATE_DECREASE = 1002,
        EDIT_CONTRACT_RATE_INCREASE = 1003,
        ADD_VEHICLE = 1004,
        DELETE_VEHICLE = 1005,
        VIEW_VEHICLE_MAINTENANCE = 1006,
        ADD_NEW_RESERVATION = 1007,
        VIEW_REPORT_TAB = 1008,
        DELETE_RESERVATIONS = 1009,
        CANCEL_RESERVATIONS = 1010,
        VIEW_DAILY_VIEW = 1011,
        ADD_CONTRACTS = 1012,
        AGREEMENT_EDIT_RATE = 1013,
        REVERSE_CALCULATION = 1014,
        ADJUSTMENT_BEFORE_TAX = 1015,
        ADJUSTMENT_AFTER_TAX = 1016,
        ENTER_PAYMENT = 1017,
        ADD_DEPOSITS = 1018,
        EDIT_DEPOSIT = 1019,
        REFUND_DEPOSIT = 1020,
        REPORT_PERMISSION_EMPLOYEE = 1021, //If a person have this key he cant access some reports(Reports mentioned in the EmployeeNoAccessReports section) in the report section
        VIEW_ADMIN_TAB = 1022,
        VIEW_LOCATION = 1023,
        VIEW_SALES_STATUS = 1024,
        DELETE_AGREEMENTS = 1025,
        VOID_AGREEMENT = 1026,
        VIEW_VEHICLE_SUMMARY = 1027,
        RESERVATION_EDIT_RATES = 1028,
        VIEW_HOME_TAB = 1029,
        VIEW_VEHICLE_TAB = 1030,
        VIEW_RESERVATION_TAB = 1031,
        VIEW_CUSTOMER_TAB = 1032,
        VIEW_AGREEMENT_TAB = 1033,
        VIEW_AGREEMENT_TRACK = 1034,
        VIEW_RENTAL_SUMMARY = 1035,
        VIEW_ADMIN_MESSAGE = 1036,
        VIEW_QUICK_LOOKUP = 1037,
        VIEW_TODO_SUMMARY = 1038,
        VIEW_RATE_SUMMARY = 1039,
        VIEW_RESERVATIONS = 1040,
        VIEW_MANAGE_INQUIRY = 1041,
        VIEW_VEHICLE_TYPE = 1042,
        VIEW_TODO = 1043,
        VIEW_ADD_CUSTOMER = 1044,
        VIEW_MAKE_AGREEMENT = 1045,
        VIEW_CONTINUE_TO_AGREEMENT = 1046,
        VIEW_DELETE_CUSTOMER = 1047,
        VIEW_ADD_AGREEMENT = 1048,
        VIEW_CUSTOMER_SUMMARY = 1049,
        VIEW_QUICKLOOKUP_AGENT = 1050,
        VIEW_CREDIT_CARD_NUMBER = 1051,
        ESTIMATED_TOTAL_RESTRICTION = 1052,
        ADDITIONALCHARGE_FOR_CUSTOMER_CHANGE = 1053,
        VIEW_VEHICLESTATUS_CHART = 1054,
        VIEW_QUICK_CHECKIN = 1055,
        VIEW_INVOICE_CREDIT_NOTE = 1056,
        VIEW_CUSTOMER_PASSWORD = 1057,//not available in development DB 
        VIEW_SURVEY = 1058, //not available in development DB 
        ADD_PAYMENT_SCHEDULE = 1059,
        EDIT_PAYMENT_SCHEDULE = 1060,
        GRACE_PAYMENT = 1061,
        SKIP_PAYMENT = 1062,
        DELETE_PAYMENT_SCHEDULE_ITEM = 1063,
        BULK_PAYMENT_UPLOAD = 1064,
        ADD_CUSTOMER = 1065,
        DELETE_CUSTOMER = 1066,
        ADD_NOTE_HISTORY = 1067,
        ADMIN_ADD_RATES = 1068,
        SUPERADMIN_PAYMENT_ADD = 1069,
        SUPERADMIN_PAYMENT_EDIT = 1070,
        SUPERADMIN_PAYMENT_GET = 1071,
        SUPERADMIN_PAYMENT_DELETE = 1072,
        SUPERADMIN_PAYMENT_SEARCH = 1073,
        SUPER_ADMIN_MANAGE_CLIENT_FEATURE = 1074,
        SUPER_ADMIN_MANAGE_CLIENT = 1075,
        SUPER_ADMIN_TRACK_CLIENT_MESSAGE = 1076,
        SUPER_ADMIN_TRACK_PAYMENT = 1077,
        SUPER_ADMIN_USER_LOGIN_HISTORY = 1078,
        SUPER_ADMIN_CLIENT_USAGE_REPORT = 1079,
        SUPER_ADMIN_RESERVATION_MODULE = 1080,
        SUPER_ADMIN_BULK_UPLOAD = 1081,
        SUPER_ADMIN_APIUSERS = 1082,
        SUPER_ADMIN_PAYMENT_DUE = 1083,
        SUPER_ADMIN_CLIENT_PAYMENT = 1099,
        // Vehicle category
        GET_VEHICLE_CATEGORY = 1084,
        SAVE_VEHICLE_CATEGORY = 1085,
        UPDATE_VEHICLE_CATEGORY = 1086,
        DELETE_VEHICLE_CATEGORY = 1087,
        GET_ALL_VEHICLE_CATEGORY = 1088,

        //Manage feature
        GET_CLIENTS_FOR_FEATURE = 1089,

        //Grab user role
        GRAB_USER_ROLE_VEHICLE_STATUS = 1090,

        VIEW_BULK_UPLOAD = 1091,
        RESERVE_STATUS_ONLY = 1092,
        HIDE_PRIMARY_AGREEMENT_SUMMARY_OF_CHARGES = 1093,
        HIDE_BILLING_EXCLUSION = 1094,
        HIDE_DEPOSIT_INFORMATION = 1095,
        HIDE_ALL_RATE_INFORMATION = 1096,
        HIDE_SOME_BUTTON_FOR_VEHICLE_OFFICER = 1097,
        HIDE_VEHICLE_EXPENSE_ADD_EDIT_DELETE = 1098,
        ADD_INVOICE_SCHEDULER = 1099,

        VIEW_INQUIRY = 1100,
        VIEW_USER_GRAB = 1101,
        VIEW_COMPANYEXPENSE_GRAB = 1102,
        VIEW_GLOBALDOCUMENTS_GRAB = 1103,
        VIEW_COMPANYEXPENSEITEM_GRAB = 1104,
        VIEW_REFERRALS_GRAB = 1105,
        VIEW_IDCONFIGURATION_GRAB = 1106,
        VIEW_VEHICLE_EXPENSES = 1107,
        EDIT_VEHICLE = 1108,
        EDIT_CUSTOMER = 1109,
        CHANGE_VEHICLE_STATUS = 1110,
        ODOMETER_EDIT_VEHICLE = 1111,
        VEHICLE_STATUS_HIDE = 1112,
        EXPORT_BUTTON_HIDE = 1113,
        VIEW_GPS_TAB = 1114,                     //[Suthakar.G 26/02/2019] - NNV-3514 - GPS Tracking Software
        BACK_DATE_FOR_DISPATCH = 1115,             //[S.Thulakshiga 19/03/2019] - NNV-3566 - New User Role  Dispatch
        VIEW_CLAIM_TAB = 1116,                     //[Abbas.B 10/07/2019] -  - Claims Tab
        EDIT_CONTRACTS = 1117,
        EDIT_RESERVATION = 1118,
        VIEW_EDIT_DAILYPLANNER = 1119,
        HIDE_SOME_BUTTONS_FROM_FROM_VEHICLE = 1120,
    }

    public enum FeatureType
    {
        DATA_PRINTING = 1,
        AUTO_AGREEMENT_NUMBER = 2,
        CUSTOM_AGREEMENT_PDF = 3,
        AGREEMENT_WITH_NEW_STATUS = 4,
        AUTO_SEARCH_VEHICLES_IN_AGREEMENT = 5,
        ADDITIONAL_DAYCHARGE_FOR_DELAY = 6,
        CUSTOM_INVOICE_PDF = 7,
        DRIVER_LICENSE_VERIFICATION = 8,
        EDIT_PENDING_PAYMENT = 9,
        AUTO_CALCULATION = 10,
        FUELLEVEL_EIGHT = 11,
        CANCELLATION_CHARGE = 12,
        CUSTOM_RESERVATION_PDF = 13,
        ADDITIONAL_DAY_HOUR_CHARGE_FOR_DELAY = 14,
        CUSTOM_EMAIL_POLICY = 15,
        DELETE_AGREEMENT = 16,
        ENCRYPT_CREDIT_CARD_NO = 17,
        ADDITIONAL_DRIVER_OPTION = 18,
        ADD_AUTO_EXPENSE = 19,
        CUSTOM_DAY_FOR_MONTH = 20,
        SPECIAL_DAY = 21,
        //DELETE_RESERVATION = 22,
        EDIT_CLOSED_AGREEMENT = 23,
        EDIT_CUSTOM_PDF = 24,
        ADVANCED_PAYMENT = 25,
        SUPPORT_METRIC = 26,
        DATE_FORMAT_CHANGE_UK = 31,  // used in reservation page
        REPLY_TO_CONFIG = 28,
        DOCUMENT_BCC = 29,
        DATE_FORMAT_CHANGE_USA = 30, //no more  use
        MESSAGE_BODY = 32,
        //AGREEMENT_SUMMERY=33
        PHONE_NUMBER_FORMAT = 33,
        PASSWORD_EXPIRY = 34,
        TYPE_BASED_AGREEMENT_NO = 35,
        INSURANCE_MANDATORY = 36,
        DAILY_FOR_HOUR = 37,
        CUSTOM_DATE_SHORT_FORMAT = 38,
        CUSTOM_DATE_LONG_FORMAT = 39,
        CUSTOM_DATETIME_PICKER_FORMAT = 40,
        DRIVING_LICENSE_SCANNING = 41,
        CHANGE_STATUS = 42,
        SECURITY_DEPOSIT = 43,
        EDIT_AGREEMENT_NUMBER = 44,
        ALWAYS_SAME_PICKUP_AND_DROP = 45,
        PAY_WITH_PAYPAL = 46,
        ROMANIA_CUSTOMER_MANDATORY = 47,
        NEW_CALCULATIONS = 48,
        NO_OF_HR_FOR_HALFDAY = 49,
        AFTER_HR_RATE = 50,
        DAY_RATE_CUSTOM_DAYS = 51,
        MAX_ONLINE_PAYMENT = 52,
        CUSTOMER_EMAIL_MANDATORY = 53,
        PROCESS_PAYMENT = 54,
        LICENSE_MANDATORY = 55,
        VALIDATE_DRIVER = 56,
        LOYALTY_FEATURE = 57,
        CHECKLIST_AVAILABLE = 58,
        INSURANCE_SPLIT_CALCULATION = 59,
        RESERVATION_STATUS_CONFIRM = 60,
        SHOW_AGREEMENT_DETAILS_WITH_MISCHARGE_REPORT = 61,
        USER_BASED_VISIBILITY_DAILYPLANNER = 62,
        VIEW_TERMS = 63,
        ADDITIONALCHARGE_FOR_CUSTOMER_CHANGE = 64,
        SURVEY = 65,
        QUICKBOOKS = 66,
        DATEOFBIRTH = 67,
        CUSTOM_VEHICLE_DETAIL_ORDER = 69,
        VEHICLE_YEAR_AND_TRANSMISSION_MANDATORY = 70,
        VEHICLE_MAINTENANCE_ALERT_DURATION = 71,
        VEHICLE_MAINTENANCE_ALERT_UNITS = 72,
        FREEZE_VEHICLE_BEFORE_MAKEIT_AVAILABLE = 73,
        INCLUDE_TAX_RATES = 74,
        PAYMENT_RECEIPT = 75,
        DEFAULT_TIME_FOR_CHECKIN_CHECKOUT = 76,
        ONEWAY_RENTAL_CHARGE = 77,
        PAYMENT_UPLOAD = 78,
        OLD_MAITNENACE_MODULE = 79,
        CUSTOM_INVOICE_REPORT = 80,
        CUSTOM_SERVICE_TRACK = 81,
        CUSTOM_PAYMENT_PDF = 82,
        VEHICLE_IN_SERVICE_DATE_CONFIG = 83,
        VEHICLE_AVAILABILITY = 84,
        VEHIVLE_MAINTENANCE_DETAIL_IMPORT = 85,
        //CustomPaymentPDF = 86, //use 82 instead
        CUSTOM_TERMS_MOBILE = 86,
        SERVICE_SCHEDULES = 87,
        CUSTOM_DEPOSIT_PDF = 88,
        QUOTE_RESERVATION = 89,
        CUSTOM_DOWNTIME_REPORT = 90,
        HOILDAY_BLOCK = 91,
        MILEAGE_CHARGE = 92,
        PAYMENT_SCHEDULER = 93,
        DISPLAY_ACTUAL_RATES = 95,
        CUSTOM_CREDIT_NOTEPDF = 96,
        CUSTOMER_PASSWORD = 97,
        INVOICE_CREDIT_NOTE = 98,
        CREDIT_NOTE = 99,
        DAY_RATE_ONLY = 100,
        MISC_CHARGE_CLACULATION_FOR_CUSTOM_DAY = 101,
        REMOVE_LICENCENUMBERVALIDATION_IN_AGREEMENT = 102,
        OPTIONAL_EMAIL_PROVIDER = 103,
        SPECIFIC_USERROLE = 104,
        PRIMARY_AGREEMENT_RESERVATION = 105,
        INACTIVE_DAYS_IN_AGREEMENT = 106,
        BYPASS_CREDITCARD_DEPOSIT = 107,
        GRACE_REPORT = 108,
        PAYMENT_WRITE_OFF_REPORT = 109,
        PAYMENT_SCHEDULE_DELAY = 110,
        VIEW_REPLACE_VEHICLE_TRACKING = 111,
        BYPASS_REIMBURSEMENT = 112,
        BYPASS_AGREEMENT_CHARGE = 113,
        BYPASS_TRAFFIC_TICKET = 114,
        HIDE_CREDIT_CARD_INFO = 115,
        GRAB_REPORTS = 116,
        CREATEINVOICE_ON_CHECKOUT = 117,
        COLLECTOR_MODULE = 118,
        LATE_PAYMENT_REPORT = 119,
        FLEET_SUMMARY_REPORT_BY_CREATED_DATE = 120,
        RISK_AGREEMENT_FEATURE = 121,
        AGREEMENT_CHARGES_FROM_INVOICE_ITEM = 122,
        AUTOMATED_PAYMENT_SCHEDULE = 123,
        AUTOMATED_EMAIL_INVOICE = 124,
        CHANGE_CURRENT_LOCATION = 125,
        SET_RETURN_VEHICLE_STATUS = 126,
        VEHICLE_ORDER_BY_DETAILS = 127,
        CUSTOMER_BIRTHDATE_BYPASS = 128,
        BULK_UPLOAD = 129,
        BYPASS_DEPOSIT = 130,
        BYPASS_PAYMENT = 131,
        BYPASS_WRITEOFF = 132,
        BYPASS_CREDITNOTE = 133,
        BYPASS_INVOICE = 134,
        BYPASS_INVOICEITEMS = 135,
        GRAB_RESERVATION_CHARGES_HIDE = 136,
        BYPASS_INVOICETYPE = 137,
        ADD_LEASEAMOUNT_TO_VEHILE_EXPENSE = 139,
        HIDE_VEHICLE_STATUS_FOR_USER = 140,
        MANDATORY_CUSTOMER_LOCATION = 141,
        BYPASS_SELECTED_PAYMENT_METHOD = 142,
        GRAB_RENTALS_SG_HIDE_REPORTS = 143,
        RESERVATION_MODULE_CONFIGURATION_FEATURE = 144,
        ENABLE_AGING_REPORT_IN_ADMIN = 145,
        AIC_EXPIRY_DATE = 146,
        RESERVATION_DEFAULT_VEHICLE_STATUS = 147,
        RESERVATION_EMAIL_NOTIFICATION_ONLY_TO_CLIENT = 148,
        GRAB_RENTAL_SG_FREEZE_BACKDATED_DATES = 149,
        MONTHLY_FINANCIAL_REPORT_CUSTOMIZED = 150,
        AGREEMENT_SUMMARY_REPORT_CUSTOMIZED = 151,
        CUSTOM_LOCATION_PDF = 152,
        SELECT_CUSTOMER_TYPE_by_RETAIL = 153,
        SELECT_CUSTOMER_LOCATION_BY_DEFAULT = 154,
        CONSOLIDATED_INVOICE_MODULE = 155,
        CUSTOM_CONSOLIDATED_INVOICE_PDF = 156,
        HTML_PRINT = 157,
        FREEZE_EDIT_FIELDS = 158,
        SHOW_CURRENT_YEAR_AS_NEXT_YEAR = 159,
        CONTRACT_REASON = 160,
        BLOCK_BACKDATING = 161,
        CHANGE_ON_RENT_VEHICLE_VIEW_NAME = 162,
        DUE_DELAY_COUNT_IN_MANAGEMENT_SUMMARY = 163,
        ADD_ADDITIONAL_DAMAGE_TYPES = 164,
        ADD_SPECIAL_COLUMNS_IN_VEHICLE_EXPORT_TO_EXCEL = 165,
        SHOW_SEARCH_VEHICLE_AVAILABILITY = 166,
        OMIT_INCLUDE_TAX_RATES = 167,
        ADD_INSURANCE_TO_VEHICLE_EXPENSE = 168,
        DOL_RENAME = 169,
        DIGITAL_SIGNATURE_PAD = 170,
        TRANSACTION_ID = 171,
        INVOICE_WITHOUT_TAX = 172,
        BLOCK_DUPLICATE_WITH_CUSTOMER_DETAILS = 173,
        NEW_DAY_RATE_CALCULATION = 174,
        NEW_PDF_PRINT = 175,
        BLOCK_MONTHLY = 176,
        G_C_AUTO_BODY_3_DECIMALS = 177,
        ADD_INVOICE_SCHEDULER = 179,
        AUDI_SINGAPORE_PHONE8 = 180,
        MISC_CHARGE_INVOICE_SCHEDULER = 181,
        HARD_STOP_AGREEMENT_RESERVATION = 182,
        LOGO_UPLOAD = 183,
        BOOKING_MAINTENANACE = 184,
        MINIMUM_HOURS = 185,
        CHECK_RESERVE_VEHICLE = 186,
        PRE_AUTHORIZE_AGREEMENT_CHECKOUT = 187,
        SEND_EMAIL_ON_AGREEMENT_SAVE = 188,
        PROJECTED_MILEAGE_MANUAL_ENTRY = 189,
        AGREEMENT_SUMMARY_REPORT_JMS = 190,
        SHOW_ADMIN_URLS = 191,
        CREDITCARD_MANDATORY = 192,
        AUTOMATED_FULL_INVOICE = 193,
        ASSIGN_VEHICLE_FOR_RESERVATION = 194,
        MOVE_VEHICLE_WITHIN_GROUP = 195,
        PASSWORD_COMPLIANCE = 196,
        // Suthakar.G [01/01/2019] Issue NNV-3446 - START
        MINIMUM_RENTAL_PERIOD = 197,
        // Suthakar.G [01/01/2019] Issue NNV-3446 - END
        DAILY_PLANNER = 198,
        DATE_TIME_FORMAT = 205,
        DATE_FORMAT = 206,
        AVAILABLE_NOTAVAILABLE_VEHICLE = 207,
        // Suthakar.G [01/01/2019] Issue NNV-3446 - START
        GPS = 208,
        // Suthakar.G [01/01/2019] Issue NNV-3446 - END
        CREDIT_CARD_PROCESSING_CHARGE = 209,
        SEND_SMS = 210,
        PAYMENT_SCHEDULER_NOT_MANDATORY = 211,   //[M.Gobiha 04/04/2019] - NNV-3565 - PAYMENT_SCHEDULER feature available but making it nonmandatory
        CHECK_OPT_IN_FOR_SMS = 212,
        CHECK_OPT_IN_FOR_EMAIL = 213,
        VIEW_CLAIM_TAB = 214,
        SHOW_USER_ACCESS_IN_VEHICLE = 215
    }

    public enum ToDoTypes
    {
        All = 0,
        PickUp = 1,
        Arrival = 2,
        Other = 3
    };
    public enum MaintenanceTypes
    {
        Schedule = 1,
        Manual = 2
    };

    //For Grab Rental
    public enum AgreementReimbursementType
    {
        Service = 1,
        Other = 2,
        Skipped = 3,
        Refund = 4
    }

    public enum TermTypes
    {
        All = 0,
        Checkout = 1,
        Checkin = 2,
        Reservation = 3
    }

    public enum ToDoPriority
    {
        High = 0,
        Medium = 1,
        Low = 2
    };

    public enum LicenseState
    {
        England
    }

    public enum StoreDay
    {
        [Description("SUNDAY")]
        SUNDAY = 1,
        [Description("MONDAY")]
        MONDAY = 2,
        [Description("TUESDAY")]
        TUESDAY = 3,
        [Description("WEDNESDAY")]
        WEDNESDAY = 4,
        [Description("THURSDAY")]
        THURSDAY = 5,
        [Description("FRIDAY")]
        FRIDAY = 6,
        [Description("SATURDAY")]
        SATURDAY = 7
    }

    public enum Transmission
    {
        [Description("Automatic")]
        Automatic = 0,
        [Description("Manual")]
        Manual = 1
    }

    public enum DamageType
    {
        [Description("Dent")]
        Dent = 1,
        [Description("Scrape Scratch")]
        Scrape_Scratch = 2,
        [Description("Chip_Crack")]
        Chip_Crack = 3,
        [Description("Internal Fixtures")]
        Internal_Fixtures = 4,
        [Description("Collision Damage")]
        Collision_Damage = 5,
        [Description("Plumbing")]
        Plumbing = 6,
        [Description("Electrical")]
        Electrical = 7,
        [Description("Heat/AC")]
        Heat_OR_AC = 8
    }

    public enum PaymentMethod
    {
        [Description("Cash")]
        Cash,
        [Description("Cheque")]
        Cheque,
        [Description("VisaCard")]
        VisaCard,
        [Description("Debit")]
        Debit,
        [Description("MasterCard")]
        MasterCard,
        [Description("DiscoverCard")]
        DiscoverCard,
        [Description("DinnerCard")]
        DinnerCard,
        [Description("AmexCard")]
        AmexCard,
        [Description("WireTransfer")]
        WireTransfer,
        [Description("ManualSlip")]
        ManualSlip,
        [Description("AuthorizationSlip")]
        AuthorizationSlip,
        [Description("Invoice")]
        Invoice,
        [Description("PrepaidVoucher")]
        //Deposit,
        PrepaidVoucher,
        [Description("OpPayment")]
        OpPayment,
        [Description("Nets")]
        Nets,
        [Description("CreditWallet")]
        CreditWallet

    }

    #region Enum only for Quickbook purpose

    public enum PropertyType
    {
        [Description("RentalFee")]
        RentalFee = 1,
        [Description("ExtraDurationCharge")]
        ExtraDurationCharge = 2,
        [Description("ExtraMileageCharge")]
        ExtraMileageCharge = 3,
        [Description("FuelCharge")]
        FuelCharge = 4,
        [Description("AdditionalCharge")]
        AdditionalCharge = 5,
        [Description("AgreementCharge")]
        AgreementCharge = 6,
        [Description("FineCharge")]
        FineCharge = 7,
        [Description("MiscellaneousCharges")]
        MiscellaneousCharges = 8,
        [Description("PaymentMethods")]
        PaymentMethods = 9,
        [Description("Deposit")]
        Deposit = 10,
        [Description("Refund")]
        Refund = 11,
        [Description("TotalTax")]
        TotalTax = 12,
        [Description("PostAdjustments")]
        PostAdjustments = 13,
        [Description("WriteOff")]
        WriteOff = 14
    }

    public enum QuickbookStatus
    {
        [Description("Saved")]
        Saved = 1,
        [Description("Save Failed")]
        Save_Failed = 2,
        [Description("Updated")]
        Updated = 3,
        [Description("Update Failed")]
        Update_Failed = 4,
        [Description("Deleted")]
        Deleted = 5,
        [Description("Delete Failed")]
        Delete_Failed = 6,
    }

    public enum QuickbookTransactionType
    {
        [Description("Agreement")]
        Agreement = 1,
        [Description("Payment")]
        Payment = 2,
        [Description("Refund")]
        Refund = 3,
        [Description("Deposit")]
        Deposit = 4
    }

    #endregion

    #region BookingMaintenance

    public enum BookingMaintenanceTime
    {
        [Description("1 AM")]
        ONE_AM = 1,
        [Description("2 AM")]
        TWO_AM = 2,
        [Description("3 AM")]
        THREE_AM = 3,
        [Description("4 AM")]
        FOUR_AM = 4,
        [Description("5 AM")]
        FIVE_AM = 5,
        [Description("6 AM")]
        SIX_AM = 6,
        [Description("7 AM")]
        SEVEN_AM = 7,
        [Description("8 AM")]
        EIGHT_AM = 8,
        [Description("9 AM")]
        NINE_AM = 9,
        [Description("10 AM")]
        TEN_AM = 10,
        [Description("11 AM")]
        ELEVEN_AM = 11,
        [Description("12 PM")]
        TWELVE_PM = 12,
        [Description("1 PM")]
        ONE_PM = 13,
        [Description("2 PM")]
        TWO_PM = 14,
        [Description("3 PM")]
        THREE_PM = 15,
        [Description("4 PM")]
        FOUR_PM = 16,
        [Description("5 PM")]
        FIVE_PM = 17,
        [Description("6 PM")]
        SIX_PM = 18,
        [Description("7 PM")]
        SEVEN_PM = 19,
        [Description("8 PM")]
        EIGHT_PM = 20,
        [Description("9 PM")]
        NINE_PM = 21,
        [Description("10 PM")]
        TEN_PM = 22,
        [Description("11 PM")]
        ELEVEN_PM = 23,
        [Description("12 AM")]
        TWELVE_AM = 24,
    }

    #endregion

    public enum PaymentMethodForPayment
    {
        [Description("Cash")]
        Cash,
        [Description("Cheque")]
        Cheque,
        [Description("VisaCard")]
        VisaCard,
        [Description("Debit")]
        Debit,
        [Description("MasterCard")]
        MasterCard,
        [Description("DiscoverCard")]
        DiscoverCard,
        [Description("DinnerCard")]
        DinnerCard,
        [Description("AmexCard")]
        AmexCard,
        [Description("WireTransfer")]
        WireTransfer,
        [Description("ManualSlip")]
        ManualSlip,
        [Description("AuthorizationSlip")]
        AuthorizationSlip,
        [Description("Invoice")]
        Invoice,
        [Description("PrepaidVoucher")]
        PrepaidVoucher,
        [Description("OpPayment")]
        OpPayment,
        [Description("Deposit")]
        Deposit,
        [Description("PreAuthorization")]
        PreAuthorization,
        [Description("Nets")]
        Nets,
        [Description("CreditWallet")]
        CreditWallet,
        [Description("TTGIRO")]
        TTGIRO

    }

    public enum FuelType
    {
        [Description("Diesel")]
        Diesel = 2,
        [Description("Gas")]
        Gas = 3,
        [Description("Electric")]
        Electric = 4,
        [Description("Hybrid")]
        Hybrid = 5,
        [Description("Petrol")]
        Petrol = 6
    }

    public enum Doors
    {
        [Description("TwoDoors")]
        TwoDoors = 2,
        [Description("FourDoors")]
        FourDoors = 4,
        [Description("FiveDoors")]
        FiveDoors = 5
    }

    public enum InvoiceTypeNumber
    {
        [Description("Manual")]
        Manual = 1,
        [Description("AutomationWithTempData")]
        AutomationWithTempData = 2,
        [Description("AutomationWithAgrement")]
        AutomationWithAgrement = 3,
        [Description("CustomerInvoiceSequence")]
        CustomerInvoiceSequence = 4
    }
    //public enum VehicleStatus
    //{

    //    Accident = 1,
    //    Available = 2,
    //    [Description("For Sale")]
    //    ForSale = 3,
    //    Grounded = 4,
    //    [Description("Has Probleme")]
    //    HasProblem = 5,
    //    [Description("In CheckOut Process")]
    //    InCheckOutProcess = 6,
    //    [Description("In Repair")]
    //    InRepair = 7,
    //    [Description("In Service")]
    //    InService = 8,
    //    [Description("On Rent")]
    //    OnRent = 9,
    //    [Description("Out Of Service")]
    //    OutOfService = 10,
    //    Sold = 11,
    //    Staff = 12,
    //    Stolen = 13,
    //    Deleted = 14,
    //    IMPOUND = 15,
    //    [Description("In Garage")]
    //    InGarage = 16,
    //    Reserve = 17,
    //    [Description("Pending Delivery")]
    //    Pending_Delivery = 18,
    //    [Description("Pending Return")]
    //    Pending_Return = 19,
    //    [Description(" Pending Disposal CheckedOut")]
    //    Pending_Disposal_CheckedOut = 20,
    //    [Description(" Pending Disposal CheckedIn")]
    //    Pending_Disposal_CheckedIn = 21,
    //    [Description(" Ready For DIsposal")]
    //    Ready_For_DIsposal = 22,
    //    Disposed = 23,
    //    [Description(" Pending Repossession ")]
    //    Pending_Repossession = 24,
    //    Others = 25

    //}

    public enum VehicleStatus
    {
        [Description("Accident")]
        Accident = 1,
        [Description("Available")]
        Available = 2,
        [Description("ForSale")]
        ForSale = 3,
        [Description("Grounded")]
        Grounded = 4,
        [Description("HasProblem")]
        HasProblem = 5,
        [Description("InCheckOutProcess")]
        InCheckOutProcess = 6,
        [Description("InRepair")]
        InRepair = 7,
        [Description("InService")]
        InService = 8,
        [Description("OnRent")]
        OnRent = 9,
        [Description("OutOfService")]
        OutOfService = 10,
        [Description("Sold")]
        Sold = 11,
        [Description("Staff")]
        Staff = 12,
        [Description("Stolen")]
        Stolen = 13,
        [Description("Deleted")]
        Deleted = 14,
        [Description("IMPOUND")]
        IMPOUND = 15,
        [Description("InGarage")]
        InGarage = 16,
        [Description("Reserve")]
        Reserve = 17,
        [Description("Pending_Delivery")]
        Pending_Delivery = 18,
        [Description("Pending_Return")]
        Pending_Return = 19,
        [Description("Pending_Disposal_CheckedOut")]
        Pending_Disposal_CheckedOut = 20,
        [Description("Pending_Disposal_CheckedIn")]
        Pending_Disposal_CheckedIn = 21,
        [Description("Ready_For_DIsposal")]
        Ready_For_DIsposal = 22,
        [Description("Disposed")]
        Disposed = 23,
        [Description("Pending_Repossession")]
        Pending_Repossession = 24,
        [Description("Others")]
        Others = 25,
        [Description("Service_Required")]
        Service_Required = 26,
        [Description("Dirty")]
        Dirty = 27,
        [Description("Pending_Installation")]
        Pending_Installation = 28,
        [Description("Pending_Registration")]
        Pending_Registration = 29,
        [Description("Replacement")]
        Replacement = 30,
        [Description("Checked_In")]
        Checked_In = 31,
        [Description("Check_In_Repair")]
        Check_In_Repair = 32,
        [Description("Check_In_Repo")]
        Check_In_Repo = 33,
        [Description("Pending_Reserve")]
        Pending_Reserve = 34,
        [Description("Repair_Complete")]
        Repair_Complete = 35,
        [Description("Shop")]
        Shop = 36,
        [Description("Smove")]
        Smove = 37,
        [Description("Rented_In_Repair")]
        RentedInRepair = 38,
        /// NNV-3299 Unique Car Rental
        [Description("Unavailable")]
        Unavailable = 39,
        [Description("Car wash")]
        Car_wash = 40,
        [Description("Smoke Smelling")]
        Smoke_Smelling = 41
    }

    //public enum VehicleStatusNew
    //{
    //    [Description("Accident")]
    //    Accident = 1,
    //    [Description("Available")]
    //    Available = 2,
    //    [Description("InRepair")]
    //    InRepair = 7,
    //    [Description("OnRent")]
    //    OnRent = 9,
    //    [Description("Staff")]
    //    Staff = 12,
    //    [Description("Stolen")]
    //    Stolen = 13,
    //    [Description("IMPOUND")]
    //    IMPOUND = 15,
    //    [Description("InGarage")]
    //    InGarage = 16,
    //    [Description("Reserve")]
    //    Reserve = 17,
    //    [Description("Pending_Delivery")]
    //    Pending_Delivery = 18,
    //    [Description("Pending_Disposal_CheckedIn")]
    //    Pending_Disposal_CheckedIn = 21,
    //    [Description("Disposed")]
    //    Disposed = 23,
    //    [Description("Others")]
    //    Others = 25,
    //    [Description("Pending_Installation")]
    //    Pending_Installation = 28,
    //    [Description("Pending_Registration")]
    //    Pending_Registration = 29,
    //    [Description("Replacement")]
    //    Replacement = 30,
    //    [Description("Checked_In")]
    //    Checked_In = 31,
    //    [Description("Check_In_Repair")]
    //    Check_In_Repair = 32,
    //    [Description("Check_In_Repo")]
    //    Check_In_Repo = 33,
    //    [Description("Pending_Reserve")]
    //    Pending_Reserve = 34,
    //    [Description("Repair_Complete")]
    //    Repair_Complete = 35,
    //    [Description("Smove")]
    //    Smove = 37,
    //    [Description("Rented_In_Repair")]
    //    RentedInRepair = 38,
    //    /// NNV-3299 Unique Car Rental
    //    [Description("Unavailable")]
    //    Unavailable = 39,
    //    [Description("Car wash")]
    //    Car_wash = 40,
    //    [Description("Smoke Smelling")]
    //    Smoke_Smelling = 41
    //}

    public enum FuelLevel
    {
        [Description("Empty")]
        Empty = 1,
        [Description("Quarter")]
        Quarter = 2,
        [Description("Half")]
        Half = 3,
        [Description("ThreeQuarter")]
        ThreeQuarter = 4,
        [Description("Full")]
        Full = 5
    }

    public enum FuelLevelEight
    {
        [Description("Empty")]
        Empty = 1,
        [Description("OneEight")]
        OneEight = 2,
        [Description("Quarter")]
        Quarter = 3,
        [Description("ThreeEight")]
        ThreeEight = 4,
        [Description("Half")]
        Half = 5,
        [Description("FiveEight")]
        FiveEight = 6,
        [Description("ThreeQuarter")]
        ThreeQuarter = 7,
        [Description("SevenEight")]
        SevenEight = 8,
        [Description("Full")]
        Full = 9
    }

    public enum CreditCardType
    {
        Visa = 1,
        Master = 2,
        American_Express = 3,
        Discover = 4,
        [Description("CreditCard")]
        Credit_Card = 5
    }

    public enum CreditCard
    {
        CreditCard = 5,
    }

    public enum CalculationType
    {
        [Description("Fixed")]
        Fixed,
        [Description("Percentage")]
        Percentage,
        [Description("Perday")]
        Perday,
        [Description("Range")]
        Range
    }

    public enum ReferenceType
    {
        Agreement = 1,
        Reservation = 2,
        Vehicle = 3,
        Customer = 4,
        PrimaryReservation = 5,
        PrimaryAgreement = 6,
        Inquiry = 7
    }

    public enum FreezeType
    {
        Agreement = 1,
        Reservation = 2,
        Vehicle = 3,
        Customer = 4,
        RentalRate = 5,
        ClosedAgreement = 6,
        VehicleNote = 7,
        WriteOff = 8,
        Reimbursement = 9,
        CustomerNote = 10,
        AgreementNote = 11,
        VehicleExchange = 12,
        CreditNote = 13,
        AgreementCharge = 14,
        Invoice = 15,
        AgreementDeposit = 16,
        ReservationDeposit = 17,
        Payment = 18,
        AgreementRefundnRelease = 19,
        ReservationRefundnRelease = 20

    }

    public enum QuoteStatus
    {
        Quote = 1
    }
    public static class SessionConstants
    {
        public static string SESSION_CONTEXT_INSTANCE = "Context";
        public static string SESSION_TEMP_CONTEXT_INSTANCE = "TempContext";
        public static string CURRENT_LIST_DATE = "Current_list";

    }

    public enum VehicleTrackStatus
    {
        //[Description("Check-out")]
        //Checkout = 1,
        //[Description("Check-in")]
        //Checkin = 2,
        //[Description("Lost")]
        //Lost = 3,
        //[Description("Damage")]
        //Damage = 4,
        [Description("Manual Maintenance")]
        ManualMaintenance = 1,
        [Description("Maintenance Schedule")]
        MaintenanceSchedule = 2,
        [Description("Personal Use")]
        PersonalUse = 3,
        [Description("Chase")]
        Chase = 4,
        [Description("Miscellaneous")]
        Miscellaneous = 5


    }

    public enum EquipmentCondition
    {
        Good = 1,
        Damage = 2,
        Lost = 3
    }

    public enum AgreementStatusConst
    {
        //New = 1,
        [Description("Open")]
        Open = 2,
        [Description("Close")]
        Close = 3,
        [Description("Cancel")]
        Cancel = 4,
        [Description("PendingPayment")]
        PendingPayment = 5,
        [Description("Void")]
        Void = 6,
        [Description("PendingDeposit")]
        PendingDeposit = 7,
        [Description("OnHold")]
        OnHold = 8,
        [Description("Draft")]
        Draft = 9,
    }

    public enum DriverTypes
    {
        Main = 1,
        Additional = 2
    }

    public enum Month
    {
        Jan = 1,
        Feb = 2,
        Mar = 3,
        Apr = 4,
        May = 5,
        Jun = 6,
        Jul = 7,
        Aug = 8,
        Sep = 9,
        Oct = 10,
        Nov = 11,
        Dec = 12
    }

    public enum PaymentMethodRef
    {
        Payment = 1,
        Deposit = 2
    }
    public enum Year
    {
        Year2004 = 2004,
        Year2005 = 2005,
        Year2006 = 2006,
        Year2007 = 2007,
        Year2008 = 2008,
        Year2009 = 2009,
        Year2010 = 2010,
        Year2011 = 2011,
        Year2012 = 2012,
        Year2013 = 2013,
        Year2014 = 2014,
        Year2015 = 2015,
        Year2016 = 2016,
        Year2017 = 2017,
        Year2018 = 2018,
        Year2019 = 2019,
        Year2020 = 2020,
        Year2021 = 2021,
        Year2022 = 2022,
        Year2023 = 2023,
        Year2024 = 2024
    }

    public enum CustomerType
    {
        BodyShop = 1,
        Dealer = 2,
        Insurance = 3,
        [Description("Retail")]
        Retail = 4
    }

    public enum TemplateTypes
    {
        AgreementOpen = 1,
        AgreementClose = 2,
        Reservation = 3,
        Invoice = 4
    }

    public enum APIConsumerType
    {
        [Description("All")]
        All = 0,
        [Description("Basic")]
        Basic = 1,
        [Description("Dynamic")]
        Dynamic = 2,
        [Description("ApiAdmin")]
        Admin = 3,
        [Description("AdminBasic")]
        AdminBasic = 4

    }

    public enum ReservationStatuses
    {
        [Description("New")]
        New = 7,
        [Description("Open")]
        Open = 2,
        [Description("CheckOut")]
        CheckOut = 3,
        [Description("NoShow")]
        NoShow = 4,
        [Description("Canceled")]
        Canceled = 5,
        [Description("Quote")]
        Quote = 6,
    }

    public enum ServiceStatus
    {
        [Description("Adjusted")]
        Adjusted = 1,
        [Description("Changed")]
        Changed = 2,
        [Description("Checked")]
        Checked = 3,
        [Description("Completed")]
        Completed = 4,
        [Description("Repaired")]
        Repaired = 5,
        [Description("Replaced")]
        Replaced = 6,
        [Description("Serviced")]
        Serviced = 7,
        [Description("Tested")]
        Tested = 8,
        [Description("ToppedUp")]
        ToppedUp = 9,
        [Description("NotPerformed")]
        NotPerformed = 10
    }

    public enum InvoiceType
    {
        [Description("Full")]
        Full = 1,
        [Description("Split")]
        Split = 2,
        [Description("Custom")]
        Custom = 3,
        [Description("Insurance")]
        Insurance = 4
    }

    public enum InvoiceStatus
    {
        [Description("Close")]
        Close = 1,
        [Description("Open")]
        Open = 2
    }

    public enum PrintPdf
    {
        Agreement = 1,
        Reservation = 2,
        Invoice = 3,
        Payment = 4,
        AgreementDeposit = 5,
        ReservationDeposit = 6,
        CreditNote = 7,
        PrimaryAgreement = 8,
        PrimaryReservation = 9,
        CustomerConsolidatedInvoice = 10,
        ReservationInvoice = 11,
    }

    public enum HtmlPrint
    {
        Agreement = 1,
        Reservation = 2,
        Invoice = 3
    }

    public enum AttributeStatus
    {
        Available = 1,
        NotAvailable = 2
    }

    public enum EmployeeNoAccessReports
    {
        CustomerList = 6,
        DepreciationReport = 29,
        FleetProfitabilityReport = 9,
        MonthlyFinancialReport = 33,
        RevenueByFleet = 22,
        LocationProfitabilityReport = 20,
        EarningBreakdown = 18,
        EarningBreakdownSummary = 19,
        FinancialSummary = 13,
        DailyBusinessReport = 12
    }

    public enum CheckListStatus //Under which page checklist should appear
    {
        PickupPreparation = 1, //Reservation
        VehicleDropOff = 2, //Damage Report //chk in
        InGarage = 3, //Vehicle
        Pickup = 4 //Damage Report //chk out
    }

    public enum GroupName //Under which heading checklist should appear
    {
        DataInspection = 1,
        VehicleInspection = 2,
        Preparation = 3,
        MandatoryDocuments = 4,
        IfTheAccidentIsSevere = 5,
        Contract = 6,
        InstructionOutside = 7,
        InstructionInside = 8,
        Customer = 9,
        Outside = 10,
        Inside = 11,
        Garage = 12,
        CleanOutside = 13,
        CleanInside = 14,
        None = 15,
        Cockpit = 16,
        Undercarriage = 17,
        VehicleTest = 18,
        damageDefault = 19,
        Exterior = 20,
        Interior = 21,
        Room1 = 22,
        Room2 = 23,
        Room3 = 24,
        Room4 = 25,
        Room5 = 26,
        Room6 = 27,
        Room7 = 28,
        Room8 = 29,
        Room9 = 30,
        Office = 31,
        CommonDetails = 32   // NNV-3308 Common details for all vehicle types- CheckList -USS
    }

    public enum FormInputType // Input types in CheckList
    {
        CheckBox = 1,
        TextArea = 2,
        TextBox = 3
    }

    public enum BillingBy
    {
        Customer = 1,
        Insurance = 2,
        Other = 3
    }

    public enum LeadTypes
    {
        WalkIN = 1,
        CallIN = 2,
        Website = 3,
        Capterra = 4,
        SalesEmail = 5

    }

    public enum DepositPaymentMethod
    {
        [Description("VisaCard")]
        VisaCard,
        [Description("Debit")]
        Debit,
        [Description("MasterCard")]
        MasterCard,
        [Description("DiscoverCard")]
        DiscoverCard,
        [Description("DinnerCard")]
        DinnerCard,
        [Description("AmexCard")]
        AmexCard,
        [Description("WireTransfer")]
        WireTransfer,
        [Description("ManualSlip")]
        ManualSlip,
        [Description("AuthorizationSlip")]
        AuthorizationSlip,
        [Description("Invoice")]
        Invoice,
        [Description("PrepaidVoucher")]
        PrepaidVoucher,
        [Description("OpPayment")]
        OpPayment,
        [Description("Nets")]
        Nets,
        [Description("CreditWallet")]
        CreditWallet
    }

    public enum DepositMethod
    {
        [Description("Deposit")]
        Deposit,
        [Description("PreAuthorization")]
        PreAuthorization
    }

    public enum LeadStatus
    {
        Lead = 1,
        Customer = 2
    }

    public enum LeadSubStatuses
    {
        NEW = 1,
        CALLED = 2,
        DEMOSCHEDULED = 3,
        PROPOSED = 4,
        CONTRACTSIGNED = 5,
        NOTINTERESTED = 6,
        SIGNED = 7,
        LOGINEMAILED = 8,
        SYSTEMConfiguration = 9,
        FIRSTTRAININGDONE = 10,
        SECONDTRAININGDONE = 11,
        WEBSITEPLUGINDONE = 12

    }

    public enum Durations
    {
        Hours = 1,
        Days = 2,
        //Weeks = 3,
        //Months = 4

    }

    public enum EmailPurpose
    {
        Agreement = 1,
        Reservation = 2,
        Invoice = 3,
        OnlineReservation = 4,
        Survey = 5,
        Leads = 6,
        AgreementDeposit = 7,
        PaymentReceipt = 8,
        ReservationDeposit = 9,
        CreditNote = 10,
        PrimaryAgreement = 11,
        PrimaryReservation = 12,
        CustomerConsolidatedInvoice = 13,
        LeaseCalculation = 14,
        InsuranceAddition = 15,
        ReservationInvoice = 16,
    }

    /// <summary>
    /// Use in invoice credit note search dropdown
    /// </summary>
    public enum CreditnoteInvoice
    {
        Invoice = 1,
        CreditNote = 2
    }

    /// <summary>
    /// Use in Primary Agreement and reservation search page as a search type
    /// </summary>
    public enum ReservationSearchTypes
    {
        PrimaryReservation = 5,
        SubReservation = 2
    }

    /// <summary>
    /// Use in Primary Agreement and reservation search page as a search type
    /// </summary>
    public enum AgreementSearchTypes
    {
        PrimaryAgreement = 6,
        SubAgreement = 1
    }

    public enum TemplateTypeNames // used for multi pdf 
    {
        Agreement = 1,
        Reservation = 2,
        Invoice = 3,
        Payment = 4,
        Deposit = 5,
        ReservationDeposit = 6,
        CreditNote = 7,
        CustomerConsolidatedInvoice = 8
    }

    public enum EmailType // Used in Email track 
    {
        Agreement = 1,
        Reservation = 2,
        Invoice = 3,
        OnlineReservation = 4,
        Survey = 5,
        Leads = 6,
        Deposit = 7,
        PaymentReceipt = 8,
        CreditNote = 10,
        PrimaryAgreement = 11,
        PrimaryReservation = 12,
        Client = 13,
        CustomerConsolidatedInvoice = 14

    }

    public enum EmailSentFrom // Used in Email track 
    {
        System = 1,
        ReservationModule = 2,
        Mobile = 3
    }

    public enum CancelChargeDateType
    {
        CreatedDate = 1,
        CheckOutDate = 2
    }

    public enum ChargeType
    {
        Percentage = 1,
        Fixed = 2
    }

    public enum ChargeFrom
    {
        BaseCharge = 1,
        TotalAmount = 2
    }

    public enum CancelChargeconditions
    {
        Prior = 1,
        Within = 2,
        IsEqual = 3
    }

    public enum IsReservationOrAgreement
    {
        [Description("AgreementDeposit")]
        AgreementDeposit = 1,
        [Description("ReservationDeposit")]
        ReservationDeposit = 2
    }

    public enum MessageModule
    {
        Agreement = 1,
        Reservation = 2,
        Invoice = 3,
        Payment = 4,
        Deposit = 5,
        CustomerConsolidatedInvoice = 6
    }

    public enum Upload //Upload file 
    {
        Payment = 1,
        Deposit = 2,
        VehicleServiceIn = 3,
        Maintanence = 4,
        CreditNode = 5,
        GracePayment = 6,
        TrafficTicket = 7
    }


    public enum UploadStaus //Upload file 
    {
        Pending = 1,
        Success = 2,
        Failed = 3
    }

    public enum uploadErrorLog
    {
        Payment = 1,
        Deposit = 2,
        TrafficTicket = 3,
    }

    public enum AutoGenerationSetUp //used in Navotar.InternalAPI 
    {
        Agreement = 1,
        Reservation = 2,
        Invoice = 3,
        OnlineReservation = 4,
        Survey = 5,
        Leads = 6,
        Deposit = 7,
        PaymentReceipt = 8
    }

    public enum SubLocationType
    {
        Service = 1,
    }

    public enum BankModule
    {
        Location,
        Customer,
        User,
    }

    //Used In AddEditVMService
    public enum Interval
    {
        [Description("Days")]
        Days = 1,
        [Description("Months")]
        Months = 2,
        [Description("Years")]
        Years = 3
    }

    //Definition of ReferenceId for each module commented front
    public enum ImageModule
    {
        Vehicle,                    //tblVehicle -> VehicleId
        Customer,                   //tblCustomer -> CustomerId
        Agreement,                  //tblAgreement -> AgreementId
        TermSign,                   //tblAgreement -> AgreementId
        VehicleIssue                //tblVehicleIssues -> IssueId
    }

    public enum DocumentReferenceType
    {
        Vehicle = 1,
        Customer = 2,
        Agreement = 3,
        Reservation = 4,
        Location = 5,
        VehicleType = 6,
        PrimaryAgreement = 7,
        PrimaryReservation = 8

    }

    public enum PromoModule
    {
        Agreement = 1,
        Reservation = 2
    }

    public enum DaysCount                   // 7 days = week, and 28days = month and 12month = 1 year,
    {
        [Description("Day1")]
        Day1 = 1,
        [Description("Week1")]
        Week1 = 7,
        [Description("Month1")]
        Month1 = 28,
        [Description("Month3")]
        Month3 = 84,
        [Description("Month6")]
        Month6 = 168,
        [Description("Month9")]
        Month9 = 252,
        [Description("Year1")]
        Year1 = 336,
        [Description("Year1AndMonths3")]
        Year1AndMonths3 = 420,
        [Description("Year1AndMonths6")]
        Year1AndMonths6 = 504,
        [Description("Year1AndMonths9")]
        Year1AndMonths9 = 588,
        [Description("Years2")]
        Years2 = 672

    }

    public enum PaymentSchedulerStatus
    {
        Paid = 1,
        Overdue = 2,
        ToBePaid = 3,
        Graced = 4,
        Skipped = 5
    }

    public enum ScheduleType
    {
        Day = 1,
        Week = 2,
        Month = 3,
        Year = 4
    }

    public enum UploadItem
    {
        Customers = 1,
        Vehicles = 2,
        //Agreements=3
        //start NNV-2264
        BeamStream = 4
        //end NNV-2264
    }

    public enum DateType
    {
        BlackoutDay = 1,
        Prep = 2,
        Wrap = 3
    }

    public enum BlackoutType
    {
        None = 1,
        Half = 2,
        Full = 3
    }

    public enum VehicleRoomSize
    {
        [Description("2 Room 8' x 16' + Slide Add 4 x 9'6 + Lav")]
        Room2 = 1,

        [Description("3 Room 8' x 12' + Lav")]
        Room3 = 2,

        [Description("7 Room 8' x 5'")]
        Room7 = 3,

        [Description("8 Room 8' x 5'")]
        Room8 = 4,

        [Description("9 Room 8' x 4'")]
        Room9 = 5

    }


    public enum VehicleHeat
    {
        Propane = 1,
        Electric = 2,
    }

    public enum VehicleHeatMakePropane
    {
        Suburban = 1,
        Atwood = 2
    }

    public enum VehicleHeatMakeElectric
    {
        Marley = 1,
        Steibel = 2,
        Seabreeze = 3
    }

    public enum AirCondition
    {
        Rooftop = 1,
        Window = 2
    }

    public enum AirConditionMakeRooftop
    {
        Dometic = 1,
        Coleman = 2
    }

    public enum DepositType
    {
        Deposit = 1,
        [Description("On-hold")]
        Onhold = 2,
        Refund = 3,
        Release = 4
    }

    //NNV-1778
    public enum CreditNoteType
    {
        Manual = 1, //OtherFee as well
        OtherFee = 2,//LatePaymentFee
        RentalFee = 3
    }

    //NNV-2264
    public enum PaymentTypes
    {
        PayPal = 1,
        BeamStream = 2,
        BankTransfer = 3,
        CardConnect = 4,
        Amex = 5
    }

    public enum BillingTypes
    {
        Onetime = 1,
        Monthly = 2,
        Yearly = 3
    }

    public enum PaymentDelay
    {
        [Description("Week1")]
        Week1 = 1,
        [Description("Week2")]
        Week2 = 2,
        [Description("Week3")]
        Week3 = 3,
        [Description("Week4")]
        Week4 = 4
    }

    public enum AgeDuration
    {
        Age_21_25 = 1,
        Age_25_Above = 2
    }


    public enum AuthorizeNetEnvironmentType
    {
        SANDBOX,
        PRODUCTION
    }

    public enum TransactionTypes
    {
        Proceed,
        Authorize,
        Refund,
        Release,
        Charge
    }

    public enum IsDemo
    {
        All = 1,
        Client = 2,
        DemoClient = 3
    }

    public enum AddressType
    {
        Home = 1,
        Business = 2,
        Temporary = 3,
        Billing = 4,
        Others = 5
    }

    public enum InquiryStatus
    {
        New = 1,
        InProgress = 2,
        Resolve = 3
    }

    public enum InquirySource
    {
        [Description("WalkIn")]
        WalkIn = 1,
        [Description("Phone")]
        Phone = 2,
        [Description("Social Media")]
        SocialMedia = 3,
        [Description("Email")]
        Email = 4,
        [Description("Gumtree")]
        Gumtree = 5,
        [Description("Google")]
        Google = 6,
        [Description("Facebook")]
        Facebook = 7,
        [Description("Referral")]
        Referral = 8
    }

    public enum Priority
    {
        Low = 1,
        Medium = 2,
        High = 3
    };
    public enum RentalPeriod                   // 7 days = week, and 28days = month and 12month = 1 year,
    {
        [Description("Week1")]
        Week1 = 7,
        [Description("Week2")]
        Week2 = 14,
        [Description("Week3")]
        Week3 = 21,
        [Description("Month1")]
        Month1 = 28,
        [Description("Month2")]
        Month2 = 56,
        [Description("Month3")]
        Month3 = 84,
        [Description("Month4")]
        Month4 = 112,
        [Description("Month5")]
        Month5 = 140,
        [Description("Month6")]
        Month6 = 168,
        [Description("Month7")]
        Month7 = 196,
        [Description("Month8")]
        Month8 = 224,
        [Description("Month9")]
        Month9 = 252,
        [Description("Month10")]
        Month10 = 280,
        [Description("Month11")]
        Month11 = 308,
        [Description("Year1")]
        Year1 = 336,


    }

    public enum UploadApiTypes
    {
        Agreement = 1,
        Reservation = 2,
        ProfileDoc = 4,
        ProfilePicture = 9
    }

    public enum PdfTypes
    {
        Agreement = 1,
        Reservation = 2,
        Invoice = 3
    }

    public enum FileExtensions
    {
        [Description(".pdf")]
        PDF = 1,
        [Description(".docx")]
        Doc = 2
    }

    public enum ToDoDate
    {
        [Description("Today")]
        Today = 1,
        [Description("7 Days")]
        Week1 = 2,
        [Description("14 Days")]
        Week2 = 3,
        [Description("30 Days")]
        Month = 4,
    }

    public enum RuleName
    {
        Freeze_Edit_Customer = 1,

        Freeze_Edit_Vehicle = 2,

        Freeze_Edit_Deposit = 3,

        Freeze_Delete_Deposit = 4,

        Freeze_Edit_AgreementChrage = 5,

        Freeze_Delete_AgreementChrage = 6,

        Freeze_Edit_Invoice = 7,

        Freeze_Delete_Invoice = 8,

        Freeze_Edit_Reimbursement = 9, //--

        Freeze_Delete_Reimbursement = 10, //--

        Freeze_Edit_Write_Off = 11, //--

        Freeze_Delete_Write_Off = 12, //--

        Freeze_Edit_CreditNote = 13,

        Freeze_Delete_CreditNote = 14,

        Freeze_Edit_Damage = 15,//--

        Freeze_Delete_VehicleExchange = 16,

        Freeze_Edit_AgreementNotesSection = 17,//--

        Freeze_Delete_AgreementNotesSection = 18,//--

        Freeze_Void_CheckIn = 19,//--

        Freeze_ChangeStatus_CheckIn = 20,//--

        Freeze_Edit_CheckIn = 21,//--

        Freeze_Edit_RentalRates = 22,

        Freeze_Delete_RentalRates = 23,

        Freeze_Edit_NotesinCustomerPage = 24,

        Freeze_Delete_NotesinCustomerPage = 25,

        Freeze_Edit_NotesinVehiclePage = 26,

        Freeze_Delete_NotesinVehiclePage = 27,

        Hide_Delete_Reservation = 28,

        Hide_Delete_Agreement = 29,

        Freeze_Edit_Agreement = 30,

        Freeze_Edit_Payment = 31,

        Freeze_Delete_payment = 32,

        Freeze_Edit_Reservation = 33
    }

    public enum PaymentAndDepositStatus
    {
        Error = 1,
        Success = 2,
        Pending = 3,
        Pending_Success = 4,
        Manual_Success = 5,
        WrittenOff = 6
    }

    public enum ContractReason
    {
        [Description("New Contract")]
        NewContract = 1,
        [Description("Re Contract")]
        ReContract = 2,
        [Description("Permanant Replacement")]
        PermanantReplacement = 3,
        [Description("Replacement Car")]
        ReplacementCar = 4
    }

    public enum ContracExtendingReason
    {
        [Description("5 weeks")]
        Weeks_5 = 1,
        [Description("3 Months")]
        Months_3 = 2,
        [Description("6 Months")]
        Months_6 = 3,
        [Description("12 Months")]
        Months_12 = 4

    }

    public enum InvoiceScheduleType
    {
        Day = 1,
        Week = 2,
        Month = 3
    }

    public enum OptionalEmailProvider
    {
        smtp = 1,
        elastic = 2
    }


    public enum BlackListReasons
    {
        [Description("Negligence of Safety (Reckless, Drink Driving, Frequent Accidents)")]
        Reason1 = 1,

        [Description("Credit Risk (Chronic Arrears)")]
        Reason2 = 2,

        [Description("Bad Attitude (Irrational, Rude to Staff)")]
        Reason3 = 3,

        [Description("Refuse to pay Excess")]
        Reason4 = 4,

        [Description("Failure to turn up for Servicing")]
        Reason5 = 5,

        [Description("MIA")]
        Reason6 = 6,

        [Description("Fraud (Incentive Gaming, Impersonation)")]
        Reason7 = 7,

        [Description("Criminal Activity")]
        Reason8 = 8


    }

    public enum ChatRoomType
    {
        Agreement = 1,
        Reservation = 2,
        Customer = 3,
        Vehicle = 4
    }
    /// <summary>
    /// Company Expense Payment Status's Category #NNV-3286
    /// </summary>
    public enum CompanyExpensePaymentStatus
    {
        Unpaid = 0,
        Paid = 1
    }

    public enum ActionType
    {
        Add = 1,
        Edit = 2,
        Delete = 3,
        Get = 4
    }

    public enum OnBordingStep
    {
        AddClient = 1,
        AddLocation = 2,
        AddStoreHours = 3,
        AddTax = 4,
        AddRate = 5,
        AddMiscCharge = 6,
        AttachAgreementPdf = 7,
        AttachLogo = 8,
        AddFeatures = 9
    }
    public enum ClientConfiguration
    {
        PaymentMethod = 1,
        Deposit_PaymentMethod = 2,
        PaymentType = 3,
        AgreementType = 4,
        ReservationType = 5,
        CustomerType = 6,
        VehicleStatus = 7
    }
}
