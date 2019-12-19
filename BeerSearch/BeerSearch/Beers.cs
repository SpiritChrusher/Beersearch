﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;

namespace BeerSearch
{
    class Beers
    {

        public static string mindensör =
            @"{
    'sör': [
      {
        'név': 'Apostel Weissbier',
        'alkohol': 5.3,
        'íz': 'Kicsit keserű, kicsit karamellás, kellemes búzasör',
        'származás': 'német',
        'típus': 'Búzasör',
        'fogyasztás': 'ivósör',
        'ár': 300,
        'minőség': 5.0,
        'beszerzés': 'Interspar, Spar',
      },
      {
        'név': 'Arany Ászok',
        'alkohol': 4.3,
        'íz': 'Kicsit keserű, enyhe íz',
        'származás': 'magyar',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 240,
        'minőség': 3.0,
        'beszerzés': 'InterSpar, Spar, Tesco',
      },
      {
        'név': 'Arany Szarvas',
        'alkohol': 4.2,
        'íz': 'Egész kellemes, nem erős íz',
        'típus': 'Lager',
        'származás': 'magyar',
        'fogyasztás': 'ivósör',
        'ár': 180,
        'minőség': 4.0,
        'beszerzés': 'Auchan',
      },
      {
        'név': 'Arany Szarvas barna',
        'alkohol': 5.2,
        'íz': 'Enyhén barnasör íz, alkoholos',
        'típus': 'Barna Lager',
        'származás': 'magyar',
        'fogyasztás': 'ivósör',
        'ár': 180,
        'minőség': 4.0,
        'beszerzés': 'Auchan',
      },
      {
        'név': 'ARGUS Maestic',
        'alkohol': 4.8,
        'íz': 'Könnyen iható, nem túl erős, korrekt lager',
        'származás': 'cseh',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 210,
        'minőség': 4.5,
        'beszerzés': 'Lidl',
      },
      {
        'név': 'ARGUS Piros',
        'alkohol': 5.0,
        'íz': 'Tipikus lager, nem túl keserű, nem túl erős, könnyen iható',
        'származás': 'cseh',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 175,
        'minőség': 4.0,
        'beszerzés': 'Lidl',
      },
      {
        'név': 'ARGUS 16 Strong',
        'alkohol': 7.0,
        'íz': 'Könnyen iható, karamelles, kicsit keserű',
        'származás': 'cseh',
        'típus': 'barna Lager',
        'fogyasztás': 'ivósör',
        'ár': 300,
        'minőség': 5.5,
        'beszerzés': 'Lidl',
      },
      {
        'név': 'ARGUS Szürke',
        'alkohol': 4.0,
        'íz': 'Gyenge lager, nem túl keserű, nagyon könnyen iható',
        'származás': 'cseh',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 170,
        'minőség': 3.5,
        'beszerzés': 'Lidl',
      },
      {
        'név': 'Asahi',
        'alkohol': 5.2,
        'íz': 'Kicsit keserű, jellegtelen íz',
        'származás': 'olasz',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 280,
        'minőség': 3.5,
        'beszerzés': 'Interspar, Tesco,',
      },
      {
        'név': 'Birra Moretti',
        'alkohol': 4.6,
        'íz': 'Kukoricás, kicsit keserű, nem jó',
        'típus': 'Lager',
        'származás': 'olasz',
        'fogyasztás': 'ivósör',
        'ár': 300,
        'minőség': 3.0,
        'beszerzés': 'InterSpar',
      },
      {
        'név': 'Birra Peroni',
        'alkohol': 4.6,
        'íz': 'Mint a kőbányai, ne idd.',
        'típus': 'Lager',
        'származás': 'olasz',
        'fogyasztás': 'ivósör',
        'ár': 290,
        'minőség': 2.0,
        'beszerzés': 'InterSpar',
      },
      {
        'név': 'Beck's',
        'alkohol': 5.0,
        'íz': 'Picit keserű utóíz, jellegtelen íz, szénsavas',
        'típus': 'Lager',
        'származás': 'Cseh',
        'fogyasztás': 'ivósör',
        'ár': ' 270',
        'minőség': 3.0,
        'beszerzés': 'Spar, TESCO, Lidl',
      },
      {
        'név': 'Bocskai Ír Vörös',
        'alkohol': 5.7,
        'íz': 'kellemes, kicsit keserű, könnyen iható vörös sör íz',
        'származás': 'magyar',
        'típus': 'Vörös Ale',
        'fogyasztás': 'félig buzulós',
        'ár': 500,
        'minőség': 6.5,
        'beszerzés': 'saját',
        'árérték': '6.5'
      },
      {
        'név': 'Borsodi Tüzes',
        'alkohol': 4.5,
        'íz': 'Enyhe, kicsit keserű, kicsit vörös sör íz',
        'származás': 'magyar',
        'típus': 'Vörös Lager',
        'fogyasztás': 'ivósör',
        'ár': 230,
        'minőség': 3.0,
        'beszerzés': 'Spar, TESCO',
      },
      {
        'név': 'Budwiser',
        'alkohol': 5.0,
        'íz': 'Nem túl erős íz, nem túl keserű, nem karakteres sör',
        'típus': 'Lager',
        'származás': 'cseh',
        'fogyasztás': 'ivósör',
        'ár': 300,
        'minőség': 3.5,
        'beszerzés': 'Auchan, TESCO, InterSpar, Spar',
      },
      {
        'név': 'Budwiser dark',
        'alkohol': 5.0,
        'íz': 'Kellemes barna sör',
        'típus': 'Lager',
        'származás': 'cseh',
        'fogyasztás': 'ivósör',
        'ár': 300,
        'minőség': 5.0,
        'beszerzés': 'Auchan, TESCO, InterSpar, Spar',
      },
      {
        'név': 'Csíki',
        'alkohol': 6.0,
        'íz': 'Közepesen keserű, korrekt íz',
        'származás': 'székelyföld',
        'típus': 'Bock',
        'fogyasztás': 'ivósör',
        'ár': 360,
        'minőség': 4.0,
        'beszerzés': 'Kocsma',
      },
      {
        'név': 'Csíki Szűretlen',
        'alkohol': 5.0,
        'íz': 'Kellemes természetes íz, enyhén komlós, könnyen iható',
        'származás': 'magyar',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 280,
        'minőség': 5.0,
        'beszerzés': 'Interspar',
      },
      {
        'név': 'De Helder mild',
        'alkohol': 3.5,
        'íz': 'Szénsavas, nagyon vizes, kicsit keserű utóíz',
        'származás': 'magyar??',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 160,
        'minőség': 2.5,
        'beszerzés': 'Tesco',
      },
      {
        'név': 'De Helder Bronz??',
        'alkohol': 3.5,
        'íz': 'Kicsit keserű, kicsit vizes, könnyen iható',
        'származás': 'magyar??',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 160,
        'minőség': 4.0,
        'beszerzés': 'Tesco',
      },
      {
        'név': 'De Helder Unfiltered',
        'alkohol': 5.0,
        'íz': 'Könnyen iható, kellemes, kicsit keserű',
        'származás': 'magyar??',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 210,
        'minőség': 4.5,
        'beszerzés': 'Tesco',
      },
      {
        'név': 'Egger',
        'alkohol': 7.2,
        'íz': 'Erős, alkoholos, édeskés íz',
        'típus': 'Bock',
        'származás': 'osztrák',
        'fogyasztás': 'ivósör',
        'ár': 250,
        'minőség': 123,
        'beszerzés': 'Aldi',
      },
      {
        'név': 'F',
        'alkohol': 5.0,
        'íz': 'kellemesen keserű, könnyen iható, finom',
        'származás': 'Belga',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 350,
        'minőség': 5.0,
        'beszerzés': 'InterSpar',
      },
      {
        'név': 'First APA',
        'alkohol': 4.8,
        'íz': 'Citrusos, kellemes íz, nem keserű',
        'származás': 'magyar',
        'típus': 'American Pale Ale',
        'fogyasztás': 'félig ivósör',
        'ár': 500,
        'minőség': 6.0,
        'beszerzés': 'TESCO, Interspar',
      },
      {
        'név': 'First IPA',
        'alkohol': 5.6,
        'íz': 'Citrusos, kellemes, kicsit keserű',
        'származás': 'magyar',
        'típus': 'Indian Pale Ale',
        'fogyasztás': 'félig ivósör',
        'ár': 500,
        'minőség': 6.0,
        'beszerzés': 'TESCO, Interspar',
      },
      {
        'név': 'Fuller's London Pride Premium Ale',
        'alkohol': 4.7,
        'íz': 'Kellemes karamellás, jó angol ale',
        'származás': 'angol',
        'típus': 'Ale',
        'fogyasztás': 'ivósör',
        'ár': 900,
        'minőség': 6.5,
        'beszerzés': 'InterSpar',
      },
      {
        'név': 'Guiness',
        'alkohol': 4.2,
        'íz': 'Kellemes, selymes, könnyű, enyhén stoutos',
        'származás': 'angol',
        'típus': 'Stout',
        'fogyasztás': 'ivósör',
        'ár': 700,
        'minőség': 7.0,
        'beszerzés': 'InterSpar',
      },
      {
        'név': 'Gyertyános Pils',
        'alkohol': 4.6,
        'íz': 'Kellemes pils típusú, enyhén keserű utóíz',
        'típus': 'Lager',
        'származás': 'magyar',
        'fogyasztás': 'ivósör',
        'ár': 370,
        'minőség': 4.5,
        'beszerzés': 'Gyertyános sörfőzde',
      },
      {
        'név': 'Gyertyános Barna Gyémánt',
        'alkohol': 5.5,
        'íz': 'Kellemesen kávés, füstös ízvilágú',
        'típus': 'Barna lager',
        'származás': 'magyar',
        'fogyasztás': 'ivósör',
        'ár': 670,
        'minőség': 5.5,
        'beszerzés': 'Gyertyános sörfőzde',
      },
      {
        'név': 'Gyertyános Kazamata',
        'alkohol': 8.0,
        'íz': 'Nyers, élesztős utóíz, könnyen iható',
        'típus': 'Imperial lager',
        'származás': 'magyar',
        'fogyasztás': 'ivósör',
        'ár': 900,
        'minőség': 4.0,
        'beszerzés': 'Gyertyános sörfőzde',
      },
      {
        'név': 'Happy Easter',
        'alkohol': 6.4,
        'íz': 'Nagyon kellemes, közepesen keserű, kicsit füstös',
        'típus': 'Amerikai Indian Pale Ale',
        'származás': 'magyar',
        'fogyasztás': 'buzulós',
        'ár': 900,
        'minőség': 8.5,
        'beszerzés': 'InterSpar, Stay',
      },
      {
        'név': 'Heineken',
        'alkohol': 5.0,
        'íz': 'Nagyon szénsavas, kellemetlenül keserű',
        'származás': 'magyar',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 280,
        'minőség': 2.0,
        'beszerzés': 'Spar, TESCO, Interspar, Coop',
      },
      {
        'név': 'Deep Kék',
        'alkohol': 3.0,
        'íz': 'Elég vizes, nagyon enyhén kesernény',
        'származás': 'német',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 120,
        'minőség': 2.0,
        'beszerzés': 'Lidl',
      },
      {
        'név': 'Deep Zöld',
        'alkohol': 4.0,
        'íz': 'Közepesen vizes, már iható enyhe lager',
        'származás': 'német',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 130,
        'minőség': 2.5,
        'beszerzés': 'Lidl',
      },
      {
        'név': 'Desperados tequila sör',
        'alkohol': 5.9,
        'íz': 'Citrusos, nem igazán tequilás, jól csúszik',
        'származás': 'lengyel',
        'típus': 'Ale',
        'fogyasztás': 'félig ivósör',
        'ár': 380,
        'minőség': 5.0,
        'beszerzés': 'TESCO',
      },
      {
        'név': 'Dreher Red Ale',
        'alkohol': 4.8,
        'íz': 'Kellemesen keserű, pörkölt utóíz, könnyen iható',
        'származás': 'német',
        'típus': 'Red Ale',
        'fogyasztás': 'ivósör',
        'ár': 280,
        'minőség': 5.5,
        'beszerzés': 'TESCO, Spar',
      },
      {
        'név': 'Edelwiess',
        'alkohol': 5.3,
        'íz': 'Definitív búzasör íz',
        'származás': 'német',
        'típus': 'Búzasör',
        'fogyasztás': 'ivósör',
        'ár': 400,
        'minőség': 5.5,
        'beszerzés': 'InterSpar, Spar',
      },
      {
        'név': 'Gösser',
        'alkohol': 5.1,
        'íz': 'Kellemes íz,kicsit keserű, jó lager',
        'származás': 'osztrák?',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 260,
        'minőség': 5.0,
        'beszerzés': 'InterSpar, Tesco',
      },
      {
        'név': 'Hoegaarden',
        'alkohol': 4.9,
        'íz': 'Tömény ízvilág, fűszeres búzasör',
        'származás': 'Begla',
        'típus': 'Begla búzasör',
        'fogyasztás': 'buzulós',
        'ár': 530,
        'minőség': 5.5,
        'beszerzés': 'Interspar, Spar, Tesco',
      },
      {
        'név': 'Hoegaarden Rosée',
        'alkohol': 4.9,
        'íz': 'Nagyon édes, málnás szörp',
        'származás': 'Begla',
        'típus': ' Belga búzasör',
        'fogyasztás': 'buzulós',
        'ár': 530,
        'minőség': 5.0,
        'beszerzés': 'Interspar, Spar, Tesco',
      },
      {
        'név': 'Hofbrau',
        'alkohol': 4.0,
        'íz': 'Vizes, lageresen keserű',
        'származás': 'német',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 210,
        'minőség': 3.0,
        'beszerzés': 'TESCO, Interspar, Spar, Coop',
      },
      {
        'név': 'Karlovacko',
        'alkohol': 5.0,
        'íz': 'Kozepesen keserű, kicsit édeskés, könnyen iható',
        'származás': 'lengyel',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 300,
        'minőség': 4.5,
        'beszerzés': 'InterSpar',
      },
      {
        'név': 'Leffe Blond',
        'alkohol': 6.6,
        'íz': 'Nagyon kellemes, selymes, kicsit búzasör íz',
        'származás': 'belga',
        'típus': 'Belga',
        'fogyasztás': 'félig ivósör',
        'ár': 500,
        'minőség': 7.0,
        'beszerzés': 'TESCO, Interspar, Spar, Coop',
      },
      {
        'név': 'Leffe Brune',
        'alkohol': 6.5,
        'íz': 'Nagyon kellemes, selymes, kicsit  barna búzasör íz',
        'származás': 'belga',
        'típus': 'Belga',
        'fogyasztás': 'félig ivósör',
        'ár': 500,
        'minőség': 7.0,
        'beszerzés': 'TESCO, Interspar, Spar, Coop',
      },
      {
        'név': 'Paulaner',
        'alkohol': 4.9,
        'íz': 'Kellemes, kicsit keserű utóíz',
        'származás': 'német',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 360,
        'minőség': 5.0,
        'beszerzés': 'Interspar',
      },
      {
        'név': 'Soproni APA',
        'alkohol': 5.5,
        'íz': 'Komlós, keserű, kellemes ízvilágú',
        'származás': 'magyar',
        'típus': 'American Pale Ale',
        'fogyasztás': 'ivósör',
        'ár': 280,
        'minőség': 5.0,
        'beszerzés': 'Spar, TESCO',
      },
      {
        'név': 'Soproni IPA',
        'alkohol': 4.8,
        'íz': 'Nem igazi IPA, gyümölcsös, nem túl erős',
        'származás': 'magyar',
        'típus': 'Indian Pale Ale',
        'fogyasztás': 'ivósör',
        'ár': 280,
        'minőség': 4.0,
        'beszerzés': 'Spar, TESCO',
      },
      {
        'név': 'Soproni Démon',
        'alkohol': 5.2,
        'íz': 'Barna sörös íz',
        'származás': 'magyar',
        'típus': 'barna',
        'fogyasztás': 'ivósör',
        'ár': 280,
        'minőség': 3.5,
        'beszerzés': 'Spar, TESCO',
      },
      {
        'név': 'Primator',
        'alkohol': 4.0,
        'íz': 'Basic cseh típusú sör',
        'típus': 'Lager',
        'származás': 'magyar',
        'fogyasztás': 'ivósör',
        'ár': 300,
        'minőség': 4.5,
        'beszerzés': 'InterSpar',
      },
      {
        'név': 'Steam Brew German Red',
        'alkohol': 7.9,
        'íz': 'Kellemes illatú, enyhén kesernény, édeskés utóíz',
        'típus': 'Red Ale',
        'származás': 'német',
        'fogyasztás': 'félig ivósör',
        'ár': 360,
        'beszerzés': 'InterSpar, TESCO',
      },
      {
        'név': 'Steam Brew Imperial Stout',
        'alkohol': 7.5,
        'íz': 'Erős, tömény, kávés ízű finom sör',
        'típus': 'Imparial Stout',
        'származás': 'német',
        'fogyasztás': 'félig ivósör',
        'ár': 360,
        'minőség': 7.0,
        'beszerzés': 'InterSpar, TESCO',
      },
      {
        'név': 'Steam Brew Imperial IPA',
        'alkohol': 4.8,
        'íz': 'Komlós, keserű, kellemes ízvilágú',
        'típus': 'Imparial IPA',
        'származás': 'német',
        'fogyasztás': 'félig ivósör',
        'ár': 360,
        'beszerzés': 'InterSpar, TESCO',
      },
      {
        'név': 'Kozel',
        'alkohol': 4.6,
        'íz': 'Komlós, kellemes ízvilágú',
        'típus': 'Lager',
        'származás': 'Cseh',
        'fogyasztás': 'ivósör',
        'ár': 270,
        'minőség': 4.0,
        'beszerzés': 'Spar, TESCO, InterSpar, Coop',
      },
      {
        'név': 'Sixtusbräu',
        'alkohol': 4.2,
        'íz': 'Basic német sör',
        'származás': 'német',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 170,
        'minőség': 3.5,
        'beszerzés': 'Spar, TESCO',
      },
      {
        'név': 'Karlskrone',
        'alkohol': 5.0,
        'íz': 'kellemes ízű, nem túl tolakodóan búztasör',
        'származás': 'Német',
        'típus': 'Búzasör',
        'fogyasztás': 'ivósör',
        'minőség': 4.5,
        'beszerzés': 'Spar, TESCO',
      },
      {
        'név': 'Dreher Bak',
        'alkohol': 7.2,
        'íz': 'Erős karamellás barna sör, elég nehéz, de kettőtől jól érezheted magad',
        'származás': 'magyar',
        'típus': 'Strong lager, BOCK',
        'fogyasztás': 'ivósör',
        'ár': 280,
        'minőség': 5.0,
        'beszerzés': 'Spar, TESCO',
      },
      {
        'név': 'Soproni 1895',
        'alkohol': 5.3,
        'íz': 'Erős keserű világos sör, elég egyedi íz, Saazer komló',
        'származás': 'magyar',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 260,
        'minőség': 3.5,
        'beszerzés': 'Spar, TESCO',
      },
      {
        'név': 'Pilsner Urquell',
        'alkohol': 4.4,
        'íz': 'Definitív cseh pils íz, elég szénsavas, keserű',
        'származás': 'magyar',
        'típus': 'cseh típusú lager',
        'fogyasztás': 'ivósör',
        'ár': 270,
        'minőség': 5.0,
        'beszerzés': 'Spar, TESCO',
      },
      {
        'név': 'Dreher (Gold)',
        'alkohol': 5.0,
        'íz': 'Az alap Dreher sör, kukoricamentesen, kissé vizes íz, kellemes nem túl keserű, a Sopronihoz hasonló',
        'származás': 'magyar',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 260,
        'minőség': 3.5,
        'beszerzés': 'Spar, TESCO',
      },
      {
        'név': 'Dreher Pale Ale',
        'alkohol': 4.8,
        'íz': 'Édeskés, nem túl keserű, gyenge íz',
        'típus': 'Pale Ale',
        'származás': 'magyar',
        'fogyasztás': 'ivósör',
        'ár': 280,
        'minőség': 4.0,
        'beszerzés': 'Auchan, TESCO, InterSpar, Spar',
      },
      {
        'név': 'Barths Extra Strong',
        'alkohol': 8.3,
        'íz': 'Nem túl okos, de cserébe kurva erős, kissé édeskés, enyhén keserű, de kurva erős. (Dara veszély)',
        'származás': 'szlovén',
        'típus': 'Strong lager',
        'fogyasztás': 'ivósör',
        'ár': 270,
        'minőség': 0.0,
        'beszerzés': 'Spar, TESCO',
      },
      {
        'név': 'Berg König Kék',
        'alkohol': 5.0,
        'íz': 'Tipikus német sör, kicsit vizesebb utóíz, könnyen iható, nem túl erős',
        'származás': 'német',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 180,
        'beszerzés': 'Aldi',
      },
      {
        'név': 'Berg König Zöld',
        'alkohol': 5.2,
        'íz': 'Tipikus német sör, nem túl erős, könnyen iható, komlós utóíz',
        'származás': 'német',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 175,
        'minőség': 4.5,
        'beszerzés': 'Aldi',
      },
      {
        'név': 'Berg König 3,0',
        'alkohol': 3.0,
        'íz': 'Vízes, nyáron, kerti munkához tökéletes',
        'típus': 'lager',
        'származás': 'lengyel',
        'fogyasztás': 'ivósör',
        'ár': 170,
        'minőség': 2.5,
        'beszerzés': 'Aldi',
      },
      {
        'név': 'Berg König Premium',
        'alkohol': 5.0,
        'íz': 'Erős illatú, enyhén keserű sör',
        'típus': 'lager',
        'származás': 'osztrák',
        'fogyasztás': 'ivósör',
        'ár': 230,
        'minőség': 4.0,
        'beszerzés': 'Aldi',
      },
      {
        'név': 'Radeberger',
        'alkohol': 4.8,
        'íz': 'Enyhén keserű, kellemes német lager',
        'típus': 'lager',
        'származás': 'német',
        'fogyasztás': 'ivósör',
        'ár': 400,
        'minőség': 6.0,
        'beszerzés': 'InterSpar',
      },
      {
        'név': 'Rastinger',
        'alkohol': 4.0,
        'íz': 'Közepesen vízes,kicsit keserű',
        'származás': 'cseh',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 180,
        'minőség': 3.0,
        'beszerzés': 'Lidl',
      },
      {
        'név': 'Kőbányai',
        'alkohol': 4.3,
        'íz': 'Vizes, keserű, nem erős, könnyen iható, valahol van benne komló is, meg dara, na az sok',
        'származás': 'magyar',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 210,
        'minőség': 2.0,
        'beszerzés': 'Spar, TESCO',
      },
      {
        'név': 'Borsodi',
        'alkohol': 4.5,
        'íz': 'Közepesen keserű, könnyen iható',
        'származás': 'magyar',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 230,
        'minőség': 3.0,
        'beszerzés': 'Spar, TESCO, Coop',
      },
      {
        'név': 'Borsodi Mester',
        'alkohol': 5.0,
        'íz': 'Édeskés íz, komlós keserű utóíz, könnyen iható, nem túl erős',
        'származás': 'magyar',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 250,
        'minőség': 4,5,
        'beszerzés': 'Spar, TESCO',
      },
      {
        'név': 'Kronnenburg 1664',
        'alkohol': 5.0,
        'íz': 'Kellemes, csak enyhén, alig érezhetően bűzasör jellegű sör',
        'típus': 'Búzasör',
        'származás': 'francia',
        'fogyasztás': 'ivósör',
        'ár': 270,
        'minőség': 6.5,
        'beszerzés': 'Spar, TESCO',
      },
      {
        'név': 'Blanc 1664',
        'alkohol': 5.0,
        'íz': 'Édeskés, kellemesen gyülölcsös nyári sör',
        'típus': 'Búzasör',
        'származás': 'francia',
        'fogyasztás': 'ivósör',
        'ár': 270,
        'minőség': 6.5,
        'beszerzés': 'Spar, TESCO',
      },
      {
        'név': 'Zipfer',
        'alkohol': 5.4,
        'íz': 'Amilyennek egy lagernek lennie kell',
        'típus': 'Lager',
        'származás': 'osztrák',
        'fogyasztás': 'ivósör',
        'ár': 300,
        'minőség': 5.5,
        'beszerzés': 'TESCO',
      },
      {
        'név': 'Ottakringer',
        'alkohol': 5.2,
        'íz': 'Kiegyensúlyozott ízvilágú',
        'típus': 'Lager',
        'származás': 'bécsi',
        'fogyasztás': 'ivósör',
        'ár': 250,
        'minőség': 5.5,
        'beszerzés': 'InterSpar',
      },
      {
        'név': 'Tequila sör',
        'alkohol': 6.0,
        'íz': 'Citromos, alkohol alig érezhető, kukoricás utóíz',
        'típus': 'világos sör',
        'származás': 'lengyel',
        'fogyasztás': 'félig ivósör',
        'ár': 230,
        'minőség': 4.0,
        'beszerzés': 'TESCO',
      },
      {
        'név': 'Kozel barna',
        'alkohol': 3.8,
        'íz': 'karamellás, enyhén pörkölt íző, visszafogott kellemes sör',
        'származás': 'cseh',
        'típus': [
          ' Barna Lager',
          ' Barna Lager'
        ],
        'fogyasztás': 'ivósör',
        'ár': 260,
        'minőség': 3.5,
        'beszerzés': 'Lidl, Aldi, Tesco, Interspar',
      },
      {
        'név': 'Meggyes barna',
        'alkohol': 6.5,
        'íz': 'Meggyes, lágy, édes íz',
        'származás': 'magyar',
        'típus': 'Lager',
        'fogyasztás': 'félig buzulós',
        'ár': 450,
        'minőség': 4.0,
        'beszerzés': 'Mob söröző',
      },
      {
        'név': 'Pilseni',
        'alkohol': 4.5,
        'íz': 'Fiatal komlós íz',
        'származás': 'magyar',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 290,
        'minőség': 3.5,
        'beszerzés': 'Mob söröző',
      },
      {
        'név': 'Pécsi Szalon Limited',
        'alkohol': 4.6,
        'íz': 'Kissé édeskés, enyhe, kellemes nyári sör',
        'származás': 'magyar',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 220,
        'minőség': 3.5,
        'beszerzés': 'Lidl, Aldi, Tesco, Interspar',
      },
      {
        'név': 'Praga Premium Pils',
        'alkohol': 4.7,
        'íz': 'Tipikus cseh sör, egyenletesen enyhén keserű',
        'származás': 'cseh',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 300,
        'minőség': 4.0,
        'beszerzés': 'Interspar',
      },
      {
        'név': 'Jam 72',
        'alkohol': 7.2,
        'íz': 'Kellemes, kicsit keserű,',
        'származás': 'magyar',
        'típus': 'Indian Pale Ale',
        'fogyasztás': 'buzulós',
        'ár': '1030',
        'minőség': 8.0,
        'beszerzés': 'Stay',
      },
      {
        'név': 'AgrárX',
        'alkohol': 8.0,
        'íz': 'Közepesen keserű, citrusos, kicsit pörkölt',
        'származás': 'magyar',
        'típus': 'félbarna Indian Pale Ale',
        'fogyasztás': 'buzulós',
        'ár': 700,
        'minőség': 7.5,
        'beszerzés': 'Stay',
      },
      {
        'név': 'Bernard barna',
        'alkohol': 5.0,
        'íz': 'Kellemes, kicsit karamelles, kicsit keserű, könnyen iható',
        'származás': 'cseh',
        'típus': 'barna',
        'fogyasztás': 'félig buzulós',
        'ár': 450,
        'minőség': 6.0,
        'beszerzés': 'Auchan',
      },
      {
        'név': 'Ceyon Buddy Teás Double IPA',
        'alkohol': 9.1,
        'íz': 'komplex, teás, közepesen keserű..',
        'származás': 'magyar',
        'típus': 'Indian Pale Ale',
        'fogyasztás': 'buzulós',
        'ár': '1030',
        'minőség': 8.5,
        'beszerzés': 'Stay',
      },
      {
        'név': 'Csíki krém sör',
        'alkohol': 4.5,
        'íz': 'Kicsit, keserű, könnyen iható',
        'származás': 'magyar',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 290,
        'minőség': 4.5,
        'beszerzés': 'Spar, Inserpsar, Tesco',
      },
      {
        'név': 'Hobgoblin',
        'alkohol': 5.2,
        'íz': 'Kellemes, nem keserű, kicsit édes, angol ale íz',
        'származás': 'angol',
        'típus': 'Ale',
        'fogyasztás': 'buzulós',
        'ár': 800,
        'minőség': 8.5,
        'beszerzés': 'Auchan,Interspar',
      },
      {
        'név': 'Konrad',
        'alkohol': 5.2,
        'íz': 'Enyhen keserű, egyedibb íző, szárazabb cseh lager',
        'származás': 'cseh',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 280,
        'minőség': 5.0,
        'beszerzés': 'Interspar',
      },
      {
        'név': 'Lobkowicz',
        'alkohol': 4.7,
        'íz': 'Közepesen keserű, cseh típus, könnyen iható',
        'származás': 'cseh',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': '300(?)',
        'minőség': 5.0,
        'beszerzés': 'Auchan',
      },
      {
        'név': 'Monkey Temple',
        'alkohol': 4.6,
        'íz': 'Kellemes, kicsit keserű, citrusos, búzasör',
        'származás': 'magyar',
        'típus': 'bajor búzasör',
        'fogyasztás': 'buzulós',
        'ár': 800,
        'minőség': 6.5,
        'beszerzés': 'Inserpsar',
      },
      {
        'név': 'Mort Subite',
        'alkohol': 4.0,
        'íz': 'Nagyon meggyes, nagyon édes',
        'származás': 'Belga',
        'típus': 'Belga',
        'fogyasztás': 'buzulós',
        'ár': 470,
        'minőség': 5.0,
        'beszerzés': 'TESCO, Interspar, Spar',
      },
      {
        'név': 'Night Shift',
        'alkohol': '10.0',
        'íz': 'Komplex, tömény, nagyon keserű, kellemes ízvilág',
        'származás': 'magyar',
        'típus': 'Russian Imparial Stout',
        'fogyasztás': 'buzulós',
        'ár': '1550',
        'minőség': 9.0,
        'beszerzés': 'Stay',
      },
      {
        'név': 'Oettinger Búza',
        'alkohol': 4.9,
        'íz': 'Alap búzasör',
        'származás': 'német',
        'típus': 'Búzasör',
        'fogyasztás': 'ivósör',
        'ár': 200,
        'minőség': 3.5,
        'beszerzés': 'TESCO, Interspar, Spar, Coop',
      },
      {
        'név': 'Oettinger Barna',
        'alkohol': 4.9,
        'íz': 'Tömény íz, kellemes, enyhés Stoutos',
        'származás': 'német',
        'típus': 'Barna Lager',
        'fogyasztás': 'ivósör',
        'ár': 240,
        'beszerzés': 'TESCO, Interspar, Spar, Coop',
      },
      {
        'név': 'Paulaner Salvator',
        'alkohol': 7.9,
        'íz': 'Erősen karamelles...',
        'származás': 'német',
        'típus': 'BOCK',
        'fogyasztás': 'félig buzulós',
        'ár': 400,
        'minőség': 6.0,
        'beszerzés': 'Auchan',
      },
      {
        'név': 'Perlenbacher',
        'alkohol': 4.9,
        'íz': 'Kicsit keserű,kicsit vizes, enyhe íz',
        'származás': 'német',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 185,
        'minőség': 5.0,
        'beszerzés': 'Lidl',
      },
      {
        'név': 'Pécsi Prémium Pils',
        'alkohol': 4.7,
        'íz': 'Nagyon enyhe, érezhetően szűretlen, kellemes nyári sör',
        'típus': 'Lager',
        'származás': 'magyar',
        'fogyasztás': 'ivósör',
        'ár': 220,
        'minőség': 4.0,
        'beszerzés': 'Auchan, TESCO',
      },
      {
        'név': 'Pécsi Szalon',
        'alkohol': 4.6,
        'íz': 'Kicsit vizes, enyhe könnyű sör, kellemtlen utóíz',
        'típus': 'Lager',
        'származás': 'magyar',
        'fogyasztás': 'ivósör',
        'ár': 220,
        'minőség': 3.0,
        'beszerzés': 'Auchan, TESCO',
      },
      {
        'név': 'Pécsi Prémium Lager',
        'alkohol': 5.0,
        'íz': 'Egész kellemes ízvilágú, de enyhén vizes',
        'típus': 'Lager',
        'származás': 'magyar',
        'fogyasztás': 'ivósör',
        'ár': 250,
        'minőség': 3.5,
        'beszerzés': 'Auchan, TESCO, Spar',
      },
      {
        'név': 'Pécsi APA',
        'alkohol': 5.0,
        'íz': 'Citrusos, kellemetlül keserű utóíz',
        'típus': 'American Pale Ale',
        'származás': 'magyar',
        'fogyasztás': 'ivósör',
        'ár': 260,
        'minőség': 3.5,
        'beszerzés': 'Auchan, TESCO, Spar',
      },
      {
        'név': 'Popstar',
        'alkohol': 6.0,
        'íz': 'Közepesen keserű, definitív IPA íz. kellemes',
        'származás': 'magyar',
        'típus': 'IPA',
        'fogyasztás': 'félig buzulós',
        'ár': '300(?)',
        'minőség': 7.0,
        'beszerzés': 'InterSpar',
      },
      {
        'név': 'Hajdú Serház Session ALe',
        'alkohol': 4.6,
        'íz': 'Kellemes, citrusos, könnyen iható',
        'származás': 'magyar',
        'típus': 'Session Ale',
        'fogyasztás': 'ivósör',
        'ár': 700,
        'minőség': 6.0,
        'beszerzés': 'Hajdúböszörmény',
        'árérték': '4.5'
      },
      {
        'név': 'Hombre Corn',
        'alkohol': 4.8,
        'íz': 'Könnyen iható, édeskés, kukoricás íz',
        'származás': 'magyar',
        'típus': 'Kukoricasör',
        'fogyasztás': 'ivósör',
        'ár': '350?',
        'minőség': 4.0,
        'beszerzés': 'Lidl',
      },
      {
        'név': 'Tokyo Lemonade',
        'alkohol': 4.2,
        'íz': 'Kellemes, kicsit keserű, belga élesztős, citrusos',
        'származás': 'magyar',
        'típus': 'belga búzasör',
        'fogyasztás': 'buzulós',
        'ár': 800,
        'minőség': 6.5,
        'beszerzés': 'Inserpsar',
      },
      {
        'név': 'Borsodi Bivaly',
        'alkohol': 6.5,
        'íz': 'Kellemetlen, keserű, rossz, nagyon enyhe,',
        'származás': 'magyar',
        'típus': 'Strong Lager',
        'fogyasztás': 'ivósör',
        'ár': 270,
        'minőség': 2.0,
        'beszerzés': 'Spar, Inserpsar, Tesco',
      },
      {
        'név': 'Grimmbergen Double',
        'alkohol': 6.5,
        'íz': 'Könnyű, barna sörös, erős karamelles ízvilág, malátás, könnyen iható',
        'származás': 'francia',
        'típus': 'Belga barna',
        'fogyasztás': 'félig buzulós',
        'ár': 450,
        'minőség': 7.0,
        'beszerzés': 'Interspar',
      },
      {
        'név': 'Meantime London IPA',
        'alkohol': 7.4,
        'íz': 'Pörkölt, erősen karamelles, közepesen keserű',
        'származás': 'angol',
        'típus': 'Lager',
        'fogyasztás': 'félig buzulós',
        'ár': 450,
        'minőség': 6.5,
        'beszerzés': 'Tesco',
        'árérték': '2.0'
      },
      {
        'név': 'Singha',
        'alkohol': 5.0,
        'íz': 'Enyhe, kevés íz',
        'származás': 'thaiföldi',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 500,
        'minőség': 3.5,
        'beszerzés': 'Auchan',
        'árérték': '2.0'
      },
      {
        'név': 'Soprni Meggy Ale',
        'alkohol': 4.0,
        'íz': 'kellemesen emgyyes, közepesen édes, enyhe',
        'származás': 'magyar',
        'típus': 'Meggy Ale',
        'fogyasztás': 'félig buzulós',
        'ár': 275,
        'minőség': 5.5,
        'beszerzés': 'Dohánybolt',
      },
      {
        'név': 'Staropramen',
        'alkohol': 5.0,
        'íz': 'Kicsit keserű, szénsavas, könnyen iható',
        'típus': 'Lager',
        'származás': 'magyar',
        'fogyasztás': 'ivósör',
        'ár': 250,
        'minőség': 3.5,
        'beszerzés': 'Auchan, TESCO, InterSpar, Spar',
      },
      {
        'név': 'Staropramen Dark',
        'alkohol': 4.4,
        'íz': 'Kcisit búzasörös, fura utóíz',
        'típus': 'barna lager',
        'származás': 'magyar',
        'fogyasztás': 'ivósör',
        'ár': 250,
        'minőség': 3.5,
        'beszerzés': 'Auchan, TESCO, InterSpar, Spar',
      },
      {
        'név': 'Staropramen Granat',
        'alkohol': 4.8,
        'íz': 'Kellemes, kicsit barnasör íz',
        'típus': 'Lager',
        'származás': 'cseh',
        'fogyasztás': 'ivósör',
        'ár': 250,
        'minőség': 4.0,
        'beszerzés': 'Auchan, TESCO, InterSpar, Spar',
      },
      {
        'név': 'Staropramen Unfiltered',
        'alkohol': 5.0,
        'íz': 'Közepesen keserű, szénsavas, könnyen iható',
        'típus': 'Lager',
        'származás': 'cseh',
        'fogyasztás': 'ivósör',
        'ár': 250,
        'minőség': 3.5,
        'beszerzés': 'Auchan, TESCO, InterSpar, Spar',
      },
      {
        'név': 'Steffl',
        'alkohol': 4.2,
        'íz': 'Nem rossz, de jellegtelen',
        'típus': 'Lager',
        'származás': 'magyar',
        'fogyasztás': 'ivósör',
        'ár': 210,
        'minőség': 3.0,
        'beszerzés': 'InterSpar',
      },
      {
        'név': 'Steiger 1473',
        'alkohol': 5.0,
        'íz': 'Enyhen keserű, pörkölt középíz, fura utóíz',
        'származás': 'cseh',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 270,
        'minőség': 4.0,
        'beszerzés': 'Auchan',
      },
      {
        'név': 'Szarvasi világos sör',
        'alkohol': 5.0,
        'íz': 'Kellemes, könnyű, kicsit édeskés',
        'származás': 'magyar',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 400,
        'minőség': 5.5,
        'beszerzés': 'InterSpar',
      },
      {
        'név': 'Szent András Rettegett Iván',
        'alkohol': 9.0,
        'íz': 'Karakteres, karamelles, étcsokis, kellems ízvilág, tömény imperial stout',
        'származás': 'magyar',
        'típus': 'Russian Imperial Stout',
        'fogyasztás': 'buzulós',
        'ár': '1150',
        'minőség': 9.0,
        'beszerzés': 'Stay, Gedeon',
      },
      {
        'név': 'Tennent's Stout',
        'alkohol': 4.7,
        'íz': 'Kellemes kávés, nem túl erős íz',
        'származás': 'skót',
        'típus': 'Stout',
        'fogyasztás': 'félig ivósör',
        'ár': 500,
        'minőség': 6.0,
        'beszerzés': 'InterSpar',
      },
      {
        'név': 'Tennent's Whiskey',
        'alkohol': 6.0,
        'íz': 'Komplex, jól csúszó',
        'származás': 'skót',
        'típus': 'whiskey sör',
        'fogyasztás': 'buzulós',
        'ár': 500,
        'minőség': 6.5,
        'beszerzés': 'InterSpar',
      },
      {
        'név': 'Tesco Finest Ale',
        'alkohol': 5.2,
        'íz': 'Kellemes, kávés, könnyen iható',
        'típus': 'Ale',
        'származás': 'angol',
        'fogyasztás': 'félig buzulós',
        'ár': 330,
        'minőség': 5.5,
        'beszerzés': 'Tesco',
      },
      {
        'név': 'Tesco Finest Stout',
        'alkohol': 4.8,
        'íz': 'Kellemes, kávés, könnyen iható',
        'típus': 'Stout',
        'származás': 'angol',
        'fogyasztás': 'félig buzulós',
        'ár': 330,
        'minőség': 6.5,
        'beszerzés': 'Tesco',
      },
      {
        'név': 'Trooper',
        'alkohol': 4.7,
        'íz': 'Lágy, kicsit keserű vörös sör íz',
        'típus': 'Red Ale',
        'származás': 'angol',
        'fogyasztás': 'buzulós',
        'ár': 900,
        'minőség': 8.0,
        'beszerzés': ',Auchan, InterSpar',
      },
      {
        'név': 'Tuborg',
        'alkohol': 4.6,
        'íz': 'Nem rossz, de jellegtelen',
        'típus': 'Lager',
        'származás': 'dánia(szerb)',
        'fogyasztás': 'ivósör',
        'ár': 200,
        'minőség': 3.0,
        'beszerzés': 'InterSpar',
      },
      {
        'név': 'Valentins',
        'alkohol': 5.3,
        'íz': 'Enyhe, korrekt búzasör íz',
        'származás': 'német',
        'típus': 'búzasör',
        'fogyasztás': 'ivósör',
        'ár': 270,
        'minőség': 4.5,
        'beszerzés': 'Aldi',
      },
      {
        'név': 'Warsteiner',
        'alkohol': 4.8,
        'íz': 'könnyen iható, közepesen komlós íz, nem keserű',
        'származás': 'német',
        'típus': 'Lager',
        'fogyasztás': 'ivósör',
        'ár': 270,
        'minőség': 4.5,
        'beszerzés': 'InterSpar',
      }
    ]
}";
           
     
        public string Sörnév { get; set; }
        public string Neve { get; private set; }
        public double Alkoholfok { get; set; }
        public string Íz { get; set; }
        public string Típus { get; set; }
        public string Származás { get; set; }
        public string Fogyasztás { get; set; }
        public int Ár { get; set; }
        public double Minőség { get; set; }
        public string Beszerzés { get; set; }

     //   [JsonProperty("árérték")]
        public int Árérték { get; set; }

        public Beers()
        {

        }

        public Beers(string sörneve)
        {
            Neve = sörneve;
        }


        public Beers(string neve, double alkoholfok, string íz, string típus, string származás, string fogyasztás, int ár, double minőség, string beszerzés) //,int árérték)
        {
            Neve = neve;
            Alkoholfok = alkoholfok;
            Íz = íz;
            Típus = típus;
            Származás = származás;
            Fogyasztás = fogyasztás;
            Ár = ár;
            Minőség = minőség;
            Beszerzés = beszerzés;
       //     Árérték = árérték;

        }

        // talán át kéne alakítani
               
        public static List<Beers> Sörlista = new List<Beers>();

        public override string ToString()
        {
            return Neve;
        }

        public static List<Beers> Feltölt(string[]a)
        {
         JObject Sörök = JObject.Parse(mindensör);

            List<Beers> lista = new List<Beers>();

        JArray sörlista = (JArray)Sörök["sör"];

            for (int i = 0; i < a.Length; i++)
            {
 
                for (int j = 0; j < sörlista.Count; j++)
                {
                    if (a[i].Equals(Sörök["sör"][j]["név"].ToString()))
                    {
                        lista.Add(new Beers
                            (
                            Sörök["sör"][j]["név"].ToString(), (double)Sörök["sör"][j]["alkohol"], Sörök["sör"][j]["íz"].ToString(),
                            Sörök["sör"][j]["típus"].ToString(), Sörök["sör"][j]["származás"].ToString(), Sörök["sör"][j]["fogyasztás"].ToString(),
                            (int)Sörök["sör"][j]["ár"], (double)Sörök["sör"][j]["minőség"], Sörök["sör"][j]["beszerzés"].ToString()//, (int)Sörök["sör"][j]["árérték"]
                            ));
                    }
                 /*   else
                    {
                        lista.Add(new Beers("nem találtam"));
                    }*/
                }
            }

            return lista;
        }

        /*
        // XML verzióra létrehozva
        public static List<Beers> Adding(String[]tömb, int b)
        {
            List<Beers> lista = new List<Beers>();

            for (int i = 0; i < b; i++)
            {
               
                lista.Add(new Beers { Sörnév = tömb[i] });
            }

            return lista;
        }

        public static void Searcing (List<Beers> lista)
        {
        //    List<Beers> lista = new List<Beers>();

            foreach (var sörikék in lista)
            {
                foreach (XmlNode item in Sörök.DocumentElement)
                {
                    if (item.Attributes[0].Value == sörikék.Sörnév)
                    {

                        sörikék.Alkoholfok = double.Parse(item["alkohol"].InnerText);
                        sörikék.Íz = item["íz"].InnerText;
                        sörikék.Típus = item["típus"].InnerText;
                        sörikék.Származás = item["származás"].InnerText;
                        sörikék.Fogyasztás = item["fogyasztás"].InnerText;
                        sörikék.Ár = int.Parse(item["ár"].InnerText);
                        sörikék.Minőség = double.Parse(item["minőség"].InnerText);
                        sörikék.Beszerzés = item["beszerzés"].InnerText;

                    }
                }
            }



         //   return lista;

        }

    

        public int penzvalto()

        {
          //  Console.WriteLine("Mennyi pénze van?");
            string bekert = Console.ReadLine();
            int penz;
            bool success = int.TryParse(bekert, out penz);
            if (success)
                return penz;
            else { return penzvalto(); }
        }

        private int Sörszám()
        {
            return XDocument
    .Load("beers.xml")
    .XPathSelectElements("//sör").Count();
        }

        public string Randombeer()
        {
            Random szam = new Random();

            int faszom = szam.Next(Sörszám() - 1);

            var sörnevek = XDocument.Load("beers.xml").XPathSelectElements("//sör").ToList();
            string melyik = sörnevek[faszom].FirstAttribute.ToString().TrimStart('n', 'é', 'v', '=');
            //.Trim(new Char[] { ' ', '"' });
            return melyik.Trim('"');
        }

        public void berugas()
        {
            penzvalto();
            //kiválasztom az árát és az alkoholfokát a söröknek, majd kiszámolom, hogy melyikkel lehet
            //a legjobban berúgni adott pénzből.

            XmlDocument sör = new XmlDocument();
            sör.Load("beers.xml");
            foreach (XmlNode item in sör.DocumentElement)
            {
                foreach (XmlNode child in item.ChildNodes)
                {
                    if (child.Value == child["alkohol"].InnerText)
                    {
                      //  Console.WriteLine("fasza ez a sör {0}", child["alkohol"].InnerText);
                    }
                }
            }

        }
        */
        public void staysober()
        {
            //mennyi sört ihat meg, hogy még józan maradjon
            //kel lhozzá alkoholfok, a felhasználó testsúlya, és, hogy mikor evett utoljára.

        }
    }
}