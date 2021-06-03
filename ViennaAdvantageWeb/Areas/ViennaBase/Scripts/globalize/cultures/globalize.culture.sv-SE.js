﻿/*
 * Globalize Culture sv-SE
 *
 * http://github.com/jquery/globalize
 *
 * Copyright Software Freedom Conservancy, Inc.
 * Dual licensed under the MIT or GPL Version 2 licenses.
 * http://jquery.org/license
 *
 * This file was generated by the Globalize Culture Generator
 * Translation: bugs found in this file need to be fixed in the generator
 */

(function( window, undefined ) {

var Globalize;

if ( typeof require !== "undefined" &&
	typeof exports !== "undefined" &&
	typeof module !== "undefined" ) {
	// Assume CommonJS
	Globalize = require( "globalize" );
} else {
	// Global variable
	Globalize = window.Globalize;
}

Globalize.addCultureInfo( "sv-SE", "default", {
	name: "sv-SE",
	englishName: "Swedish (Sweden)",
	nativeName: "svenska (Sverige)",
	language: "sv",
	numberFormat: {
		",": " ",
		".": ",",
		negativeInfinity: "-INF",
		positiveInfinity: "INF",
		percent: {
			",": " ",
			".": ","
		},
		currency: {
			pattern: ["-n $","n $"],
			",": ".",
			".": ",",
			symbol: "kr"
		}
	},
	calendars: {
		standard: {
			"/": "-",
			firstDay: 1,
			days: {
				names: ["söndag","måndag","tisdag","onsdag","torsdag","fredag","lördag"],
				namesAbbr: ["sö","må","ti","on","to","fr","lö"],
				namesShort: ["sö","må","ti","on","to","fr","lö"]
			},
			months: {
				names: ["januari","februari","mars","april","maj","juni","juli","augusti","september","oktober","november","december",""],
				namesAbbr: ["jan","feb","mar","apr","maj","jun","jul","aug","sep","okt","nov","dec",""]
			},
			AM: null,
			PM: null,
			patterns: {
				d: "yyyy-MM-dd",
				D: "'den 'd MMMM yyyy",
				t: "HH:mm",
				T: "HH:mm:ss",
				f: "'den 'd MMMM yyyy HH:mm",
				F: "'den 'd MMMM yyyy HH:mm:ss",
				M: "'den 'd MMMM",
				Y: "MMMM yyyy"
			}
		}
	},
	messages: {
	    "Connection": "Anslutning",
    "Defaults": "Standardinställningar",
    "Login": "Inloggning",
    "File": "Fil",
    "Exit": "Avsluta",
    "Help": "Hjälp",
    "About": "Om",
    "Host": "Värddatorn",
    "Database": "Databas",
    "User": "Användarnamn",
    "EnterUser": "Ange program användarnamn",
    "Password": "Lösenord",
    "EnterPassword": "Ange program lösenord",
    "Language": "Språk",
    "SelectLanguage": "Välj ditt språk",
    "Role": "Roll",
    "Client": "Klient",
    "Organization": "Organisation",
    "Date": "Datum",
    "Warehouse": "Lager",
    "Printer": "Skrivare",
    "Connected": "Anslutad",
    "NotConnected": "Ej ansluten",
    "DatabaseNotFound": "Hittade inte databasen",
    "UserPwdError": "User does not match password",
    "RoleNotFound": "Hittade inte rollen",
    "Authorized": "Auktoriserad",
    "Ok": "Ok",
    "Cancel": "Avbryt",
    "VersionConflict": "Versionskonflikt:",
    "VersionInfo": "Server <> Klient",
    "PleaseUpgrade": "Kör updateringsprogram",


    //New Resource

    "Back": "Tillbaka",
    "SelectRole": "Välj roll",
    "SelectOrg": "Välj Organisation",
    "SelectClient": "Välj klient",
    "SelectWarehouse": "Välj Warehouse",
    "VerifyUserLanguage": "Verifiera användare och språk",
    "LoadingPreference": "Laddar preferens",
    "Completed": "Avslutade",
        "RememberMe": "Kom ihåg mig",
        "FillMandatoryFields": "Fyll obligatoriska fält",
        "BothPwdNotMatch": "Båda lösenorden måste matcha.",
        "mustMatchCriteria": "Minsta längd för lösenord är 5. Lösenord måste ha minst 1 versaler, 1 gemener, ett specialtecken (@ $!% *? &) Och en siffra. Lösenord måste börja med tecken.",
        "NotLoginUser": "Användaren kan inte logga in på systemet",
        "MaxFailedLoginAttempts": "Användarkontot är låst. Maximala misslyckade inloggningsförsök överskrider den definierade gränsen. Vänligen kontakta till administratören.",
        "UserNotFound": "Användarnamn är felaktigt.",
        "RoleNotDefined": "Ingen roll definierad för den här användaren",
        "oldNewSamePwd": "gamla lösenord och nytt lösenord måste vara annorlunda.",
        "NewPassword": "Nytt VA-lösenord",
        "NewCPassword": "Bekräfta nytt VA-lösenord",
        "EnterOTP": "Ange OTP",
        "WrongOTP": "Fel OTP anges",
        "ScanQRCode": "Skanna koden med Google Authenticator",
        "EnterVerCode": "Ange OTP genererad av din mobilapplikation",
        "PwdExpired": "Användarens lösenord har gått ut",
        "ActDisabled": "Kontot har inaktiverats",
        "ActExpired": "Kontot har gått ut",
        "AdminUserNotFound": "Administratörens användarnamn är felaktigt.",
        "AdminUserPwdError": "Adminanvändare matchar inte lösenordet",
        "AdminPwdExpired": "Administratörs lösenord har gått ut",
        "AdminActDisabled": "Administratörskonto har inaktiverats",
        "AdminActExpired": "Administratörskonto har gått ut",
        "AdminMaxFailedLoginAttempts": "Admin-användarkontot är låst. Maximalt misslyckade inloggningsförsök överskrider den definierade gränsen. Vänligen kontakta till administratören.",
	}
});

}( this ));