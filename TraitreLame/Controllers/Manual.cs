﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraitreLame.Controllers
{
    public class Manual
    {
        public static string GetManual()
        {
            return @"
{
  ""manual"": [
    {
      ""title"": ""Mécanique de base"",
      ""section"": [
        {
          ""title"": ""Mécanique de combat"",
          ""section"": [
            {
              ""title"": ""Points de vie"",
              ""description"": ""Chaque joueur commence avec 3 points de vie et ne peut jamais en avoir plus que 10. Quand un joueur tombe à 0 point de vie, la prochaine touche sur un de ses membres le prive de ce membre (jusqu’à guérison d’un point de vie utilisé à cet effet). La prochaine touche au torse ou sur un membre coupé le rend assommé.""
            },
            {
              ""title"": ""Dégât"",
              ""description"": ""Toutes les armes de mêlée ou de lancer infligent 1 point de dégât. Les flèches font 2 points de dégât. Il n’est jamais possible d’infliger plus de 3 points de dégât avec une arme.""
            },
            {
              ""title"": ""Armes et bouclier"",
              ""description"": ""On considère à deux mains toute arme d’une longueur totale entre 130 cm et 210 cm, aucune arme ne peut dépasser cette dimension. Un joueur ne peut manier une autre arme, ou utiliser un bouclier, s’il utilise une arme à deux mains. Une arme brune est considérée comme étant en bois et ne fait aucun dégât. Tous les boucliers doivent mesurer moins de 100 cm dans leur plus grande dimension et être conçus de matériaux réalistes. Les boucliers bloquent tous les projectiles, incluant les sorts, mais pas ceux des engins de siège. L’organisation se réserve le droit de refuser toute arme ou tout bouclier qu’elle juge dangereux.""
            },
            {
              ""title"": ""Armure"",
              ""description"": ""Un plastron de cuir confère 1 point de vie. Un plastron de métal confère 2 points de vie. Une protection aux jambes et aux bras confère 1 point de vie supplémentaire. Les points de vie de l’armure sont les premiers à être perdus en combat. Une armure ainsi brisée doit être réparée par la technique forgeron hors-combat au coût d’un point d’énergie pour conférer à nouveau ses points de vie.""
            },
            {
              ""title"": ""Le karma et la mort"",
              ""description"": ""Un joueur assommé n’est pas mort. Pour tuer un joueur, il faut lui faire une touche au torse alors qu’il est assommé en déclarant achever ce joueur. Cette action incombe une pénalité d’un point au karma du joueur qui achève. Le karma est la mesure d’un personnage par rapport à la faveur divine. Quand un joueur meurt et qu’aucun autre joueur n’a la capacité de le ramener à la vie, il peut se rendre au cimetière 2 minutes après les hostilités, payer 5 points de karma et attendre 10 minutes au cimetière avant de retourner au jeu au maximum de sa capacité (excepté pour ses habiletés de production et rituel). Les joueurs commencent chaque jeu avec 10 points de karma et peuvent revenir à la vie au cimetière s’il leur reste au moins 1 point de karma. Si un joueur n’a plus de karma, ou un karma négatif, il peut abandonner son personnage ou attendre au sol d’être ramené à la vie par un autre joueur.""
            }
          ]
        },
        {
          ""title"": ""Création de personnage"",
          ""section"": [
            {
              ""title"": ""Départ"",
              ""description"": ""Un nouveau personnage commence avec 2 points d’énergie et 6 points d’expérience à distribuer. Le joueur peut choisir jusqu’à deux disciplines parmi les 4 suivantes: combattante, sournoise, magique et professionnelle. Pour chaque discipline, il doit choisir deux habiletés. Il peut ensuite dépenser ses points d’expérience de départ parmi les habiletés choisies et celles de la discipline commune. Il n’est pas possible d’avoir plus de 3 points d’expérience dans une habileté donnée au départ.""
            },
            {
              ""title"": ""Progression"",
              ""description"": ""À chaque jeu, un personnage obtient 1 point d’expérience. Le joueur investit ce point d’expérience dans l’une de ses habiletés, jusqu’à concurrence de 3 points par habileté. Quand un joueur atteint 3 points d’expérience dans chacune de ses habiletés, en dehors de la discipline commune, il obtient 4 nouvelles habiletés. Cela n’arrive qu’une seule fois dans la vie d’un personnage. Comme au départ, il choisit 2 habiletés pour 2 disciplines, ou deux fois la même discipline. Il est possible de choisir une habileté que l’on possède déjà. À ce moment, le joueur pourra investir 2 points d’expérience additionnels dans cette habileté. Il peut alors aller chercher les 5 techniques de l’habileté visée. Voir l’annexe 1 en page 14 pour un exemple de progression de personnage.""
            },
            {
              ""title"": ""Remplacement"",
              ""description"": ""Un nouveau joueur peut toujours changer de personnage sans pénalité d’expérience à son second jeu. Il peut refaire les statistiques de son personnage ou le changer au complet à sa guise. À tout autre moment, un joueur peut créer un nouveau personnage selon la mécanique décrite en début de section. Il ajoute à ses points d’expérience de départ la moitié des points d’expérience cumulés par son personnage actuel. Un changement de personnage est irrévocable.""
            }
          ]
        },
        {
          ""title"": ""Magie"",
          ""section"": [
            {
              ""title"": ""Sorts"",
              ""description"": [
                ""Toutes les techniques de la discipline magique n’étant pas passive sont considérées comme des sorts. Afin d’utiliser un sort, il est nécessaire de prononcer une formule de 12 syllabes au choix du joueur qui est attaché à la technique précise que l’on désire utiliser en plus de dépenser un point d’énergie. La formule doit être crédible dans l’univers de jeu de Traitre-Lame. Dans le cas d’une technique de production, il est nécessaire de produire une formule pour chacun des objets que l’on crée. Cette formule est consignée dans un livre de sort. Sans livre, un magicien ne peut pas faire usage de ses sorts."",
                ""Les sorts ayant la portée [touché] ou [balle] peuvent être transmis au moyen d’une arme de bois. Tout sort peut être invoqué et conservé pour utilisation future. Au moment de prononcer la formule d’un tel sort, le joueur doit lever sa main, son arme de bois ou sa balle au ciel. Tant que la main du joueur est au ciel, le sort est maintenu. Toute hostilité physique envers le joueur (ex. : une touche avec une arme ou avec la main) met fin au sort, gaspillant le point d’énergie. Cette règle est applicable aux rituels à portée similaire.""
              ]
            },
            {
              ""title"": ""Rituel"",
              ""description"": [
                ""Un rituel est un sort de pouvoir supérieur nécessitant une mémorisation avant usage. L’usage d’un rituel se décline en trois étapes : l’apprentissage, la mémorisation et l’utilisation."",
                [
                  ""Apprentissage : Au moment de choisir l’habileté rituel, le joueur choisit une école de spécialisation parmi les suivantes : élémentaire, protection, nécromancie, démonologie ou naturelle. Il choisit ensuite 2 des 3 rituels présentés pour son école aux pages 12 et 13. Il peut aussi apprendre l’école de création avec la technique infusion, cette école répondant à des règles particulières présentées en page 13. Il existe aussi plusieurs rituels à apprendre en jeu. Tous les rituels et leurs détails doivent être inscrits dans un livre de sort (ou l’équivalent)."",
                  ""Mémorisation : Pour mémoriser un rituel, le joueur doit produire une cérémonie spécifique pour chacun de ces rituels connus. Ces cérémonies doivent cumuler autant de points de protocole que le nombre de composantes magiques nécessaires pour faire la cérémonie. La façon d’obtenir des points de protocole est décrite à l’annexe 2 : points de protocole en page 15. La cérémonie de mémorisation peut seulement être accomplie hors combat."",
                  ""Utilisation : Une fois le rituel mémoriser, le joueur doit prononcer la formule de 12 syllabes qu’il a composée pour son rituel, en suivant les mêmes règles que pour tout autre sort. Il applique l’effet de son rituel selon sa description.""
                ],
                ""Note : les objets baguettes et baguettes enchantées permettent à un mage de mémoriser instantanément le dernier rituel mémorisé en payant son coût en composantes. Une baguette est détruite après usage, alors qu’une baguette enchantée peut être utilisée une fois par combat. L’usage de baguettes successives mémorisent toujours le même rituel.""
              ]
            }
          ]
        },
        {
          ""title"": ""Effets de jeu"",
          ""title_html"": ""Effets de jeu <span class='label label-info'><span class='glyphicon glyphicon-info-sign'></span> Super important!!!</span>"",
          ""description"": [
            [
              ""Assommé : tombe inconscient jusqu’à la fin des hostilités. Après 2 minutes de calme, le joueur revient à ses esprits sans énergie et avec 2 points de vie."",
              ""Aveugle : ferme les yeux pour 5 secondes."",
              ""Caché : ne peut être vu. Le joueur doit croiser les bras devant lui. Toute personne l’ayant vu croiser les bras est immunisée à l’effet."",
              ""Calme : enragé et peur prennent fin et sont sans effet tant que l’effet perdure."",
              ""Cassé : l’arme ou le bouclier doit être rangé. Il peut être réparé par la technique forgeron hors-combat pour un point d’énergie."",
              ""Démembré : le membre touché est inutilisable. Le regain d’un point de vie doit être consacré au membre pour le guérir."",
              ""Désarmé : jette son arme au sol ou la remet à sa ceinture (au choix de la cible)."",
              ""Dominé : obéis aux ordres verbaux de l’initiateur."",
              ""Enragé : attaque la personne la plus près d’elle sans considération pour les autres. Prend fin quand le joueur ou sa cible est assommé."",
              ""Foudroyé : place un genou au sol."",
              ""Hors-combat : ne peut être utilisé si le joueur peut entendre une bataille."",
              ""Immatériel : est invisible et intangible. Le joueur croise les bras au-dessus de sa tête."",
              ""Mort : tombe au sol et ne prend aucune action. Voir le karma et la mort pour plus de détails."",
              ""Muet : perd l’usage de la parole. Revient au moment d’un repos."",
              ""Paralysé : ne peut pas bouger."",
              ""Peur : s’éloigne de l’initiateur au meilleur de ses capacités pour 10 pas."",
              ""Repos : méditation de 5 minutes hors-combat à la fin de laquelle le joueur reprend l’ensemble de ses points de vie (sauf ceux liés à l’armure) et d’énergie."",
              ""Nécrose : enlève un point de vie maximum. Cumulable.""
            ]
          ]
        },
        {
          ""title"": ""Objets de jeu et objets personnels"",
          ""description"": [
            ""Il est possible de dépouiller un joueur assommé, mort ou paralysé. Pour se faire, il faut chercher le corps du joueur pour la représentation de cet objet et le déposer à côté de lui. Par exemple, une armure magique peut être dérobée en retirant l’armure du cadavre. Si un joueur traine des potions, il faudrait trouver ses récipients. Un objet sans représentation physique décorum (comme un bloc) est représenté par son carton. Une fois l’objet déposé aux côtés du corps, le joueur remet les cartons d’objet à son détrousseur, si applicable. Il n’est jamais permis de cacher des possessions dans ses sous-vêtements. Chaque joueur est responsable de représenter lui-même ses objets de jeu. Par conséquent, si un joueur vole une arme magique, il doit lui-même fournir une arme règlementaire pour la représenter."",
            ""Les objets remis par l’organisation, à l’exception des papiers d’objets, doivent toujours être redonnés à l’organisation à la fin du jeu (en personne ou au cabanon de rangement).""
          ]
        }
      ]
    },
    {
      ""title"": ""Habiletés et Techniques"",
      ""title_html"": ""Habiletés et techniques"",
      ""description"": [
        ""Les habiletés déterminent les possibilités d’un personnage en jeu. Chaque joueur peut puiser ses habiletés parmi 5 disciplines : commune, combattante, sournoise, magique et professionnelle."",
        ""Chaque habileté donne accès à 5 techniques selon deux modèles :"",
        ""<h3>Linéaire [l]</h3>"",
        ""Les techniques sont acquises dans l’ordre présenté. Elles ont une progression numérique régulière affectant une statistique ou une production précise."",
        ""<h3>Choix [c]</h3>"",
        ""Chaque point d’expérience investi dans l’habileté permet de choisir une technique parmi les 5."",
        ""Les techniques représentent les possibilités du joueur en jeu. L’usage d’une technique coute toujours 1 point d’énergie. Ceci inclus, mais n’est pas limité à, l’usage d’une sauvegarde, la production d’un objet, annoncer une technique, mais rater sa cible, faire usage d’un rituel ou désarmer un piège."",
        ""<h3>Légende</h3>"",
        [
          ""[Production] génère 4 blocs de production du nom de la technique à chaque jeu."",
          ""[Touche] frappe avec une arme à l’endroit précisé."",
          ""[Dague] frappe avec une arme de mêlée de moins de 60 cm."",
          ""[Sauvegarde] contre l’effet spécifié. Le joueur doit dire le mot «sauvegarde»."",
          ""[Touché] main libre touche la cible."",
          ""[Balle] main libre, arme de bois ou une balle touche la cible."",
          ""[Passif] toujours active, ne nécessitant pas d’énergie ou d’activation."",
          ""[Toxine] il est nécessaire d’appliquer une toxine sur sa lame pour utiliser l’habileté.""
        ]
      ],
      ""section"": [
        {
          ""title"": ""Discipline Commune"",
          ""section"": [
            {
              ""title"": ""Endurance [l]"",
              ""description"": [
                [
                  ""+1 point de vie maximum"",
                  ""+1 point de vie maximum"",
                  ""+1 point de vie maximum""
                ]
              ]
            },
            {
              ""title"": ""Énergie [l]"",
              ""description"": [
                [
                  ""+2 points d’énergie maximum"",
                  ""+2 points d’énergie maximum"",
                  ""+2 points d’énergie maximum""
                ]
              ]
            }
          ]
        },
        {
          ""title"": ""Discipline Combattante"",
          ""section"": [
            {
              ""title"": ""Discipline [c]"",
              ""description"": [
                [
                  ""Résilience [passif] n’a pas à simuler la douleur en combat"",
                  ""Endurcie [passif] peur est remplacé par foudroyé"",
                  ""Loyauté [passif] sous domination, peut refuser de trahir sa faction"",
                  ""Doctrine [passif] choisit une cible qu’il peut atteindre en mêlée lorsqu’enragé"",
                  ""Vigilance [pointe la cible et attend 5 secondes] perce l’effet caché""
                ]
              ]
            },
            {
              ""title"": ""Karma [l]"",
              ""description"": [
                [
                  ""+2 points de karma au début du jeu"",
                  ""+2 points de karma au début du jeu"",
                  ""+2 points de karma au début du jeu"",
                  ""+2 points de karma au début du jeu"",
                  ""+2 points de karma au début du jeu""
                ]
              ]
            },
            {
              ""title"": ""Offense [c]"",
              ""description"": [
                [
                  ""Assaut [touche au torse] +1 dégât physique"",
                  ""Jambette [touche à la jambe] foudroyé"",
                  ""Désarmement [touche à l’avant-bras] désarmé"",
                  ""Coupe-souffle [touche au ventre] muet"",
                  ""Charge [après une course de 3 pas] +1 dégât physique""
                ],
                ""Assaut"",
                {
                  ""type"": ""image"",
                  ""src"": ""static/resources/media/assaut.png""
                },
                ""Jambette"",
                {
                  ""type"": ""image"",
                  ""src"": ""static/resources/media/jambette.png""
                },
                ""Désarmement"",
                {
                  ""type"": ""image"",
                  ""src"": ""static/resources/media/désarmement.png""
                },
                ""Coupe-souffle"",
                {
                  ""type"": ""image"",
                  ""src"": ""static/resources/media/coupe-souffle.png""
                }
              ]
            },
            {
              ""title"": ""Défense [c]"",
              ""description"": [
                [
                  ""Esquive [sauvegarde] foudroyé"",
                  ""Déflexion [sauvegarde] désarmé"",
                  ""Déviation [sauvegarde] démembré"",
                  ""Santé [sauvegarde] <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>nécrose</a>"",
                  ""Second Souffle [sauvegarde] assommé (sauf si à 0 point de vie)""
                ]
              ]
            }
          ]
        },
        {
          ""title"": ""Discipline Sournoise"",
          ""section"": [
            {
              ""title"": ""Alchimie [l]"",
              ""description"": [
                [
                  ""Alchimie [production] poison, toxine et venin"",
                  ""+2 blocs de production alchimique"",
                  ""+2 blocs de production alchimique"",
                  ""+2 blocs de production alchimique"",
                  ""+2 blocs de production alchimique""
                ]
              ]
            },
            {
              ""title"": ""Embuscade [c]"",
              ""description"": [
                [
                  ""Camouflage [immobile] peut se cacher en forêt"",
                  ""Dissimulation [immobile] peut se cacher dans le noir"",
                  ""Capture [avec une corde] la cible ne peut faire usage d’évasion"",
                  ""Piège [attacher les deux extrémités du piège] permet de poser un piège"",
                  ""Aveuglement [Toxine, Dague au torse] aveuglé""
                ]
              ]
            },
            {
              ""title"": ""Fourberie [c]"",
              ""description"": [
                [
                  ""Attaque sournoise [touche au dos] +1 de dégât physique. Cumulatif avec venin."",
                  ""Coup bas [Toxine, Dague à un rein] paralysé 5 secondes"",
                  ""Coup sonnant [Toxine, Dague entre les omoplates] assommé"",
                  ""Coupe-jarret [Dague derrière la jambe] démembré"",
                  ""Stylet [Dague à la main] démembré.""
                ],
                ""Coup bas"",
                {
                  ""type"": ""image"",
                  ""src"": ""static/resources/media/coup_bas.png""
                },
                ""Coup sonnant"",
                {
                  ""type"": ""image"",
                  ""src"": ""static/resources/media/coup_sonnant.png""
                },
                ""Coupe-jarret"",
                {
                  ""type"": ""image"",
                  ""src"": ""static/resources/media/coupe-jarret.png""
                },
                ""Stylet"",
                {
                  ""type"": ""image"",
                  ""src"": ""static/resources/media/stylet.png""
                }
              ]
            },
            {
              ""title"": ""Travail de précision [c]"",
              ""description"": [
                [
                  ""Serrurier [touché, 30 secondes] ouvre un cadenas"",
                  ""Évasion [30 secondes sans bouger ou être touché, sauvegarde] paralysé"",
                  ""Désamorçage [touché, 30 secondes] désarme et détruit un piège"",
                  ""Torture [touché, 30 secondes] doit répondre à une question (pas un effet de vérité)"",
                  ""Vol à la tire : place un objet sans être vu dans une poche. Peut prendre le contenu de la poche ou y déposer un objet au choix.""
                ]
              ]
            }
          ]
        },
        {
          ""title"": ""Discipline Magique"",
          ""section"": [
            {
              ""title"": ""Artisanat Arcane [c]"",
              ""description"": [
                [
                  ""Mixture de potions [production] potions"",
                  ""Enchantement [production] objets enchantés"",
                  ""Infusion [passif] accès aux rituels de création"",
                  ""Réparation [touché] répare une armure ou un objet cassé"",
                  ""Disjonction [touché, 1 composante] retire l’aspect enchanté. Mets fin à un rituel.""
                ]
              ]
            },
            {
              ""title"": ""Rituel [l]"",
              ""description"": [
                [
                  ""+6 composantes au début du jeu"",
                  ""+3 composantes au début du jeu"",
                  ""+3 composantes au début du jeu"",
                  ""+3 composantes au début du jeu"",
                  ""+3 composantes au début du jeu.""
                ]
              ]
            },
            {
              ""title"": ""Sorcellerie [c]"",
              ""description"": [
                [
                  ""Frénésie [balle] enragé"",
                  ""Terreur [balle] apeuré"",
                  ""Noirceur [balle] aveuglé"",
                  ""Silence [balle] muet"",
                  ""Éclair [balle] 3 points de dégât.""
                ]
              ]
            },
            {
              ""title"": ""Thaumaturgie [c]"",
              ""description"": [
                [
                  ""Guérison [touché] redonne 1 PV"",
                  ""Réanimation [touché] réveille d’assommé avec 0 point de vie et tous ses membres"",
                  ""Résurrection [touché, hors combat] passe de mort à assommé."",
                  ""Liberté [touché] met fin à la paralysie"",
                  ""Voix [touché] met fin à muet.""
                ]
              ]
            }
          ]
        },
        {
          ""title"": ""Discipline Professionnel"",
          ""section"": [
            {
              ""title"": ""Baratin [c]"",
              ""description"": [
                [
                  ""Diplomatie : permet de savoir si la dernière affirmation est vraie"",
                  ""Mensonge [sauvegarde] vérité et diplomatie"",
                  ""Revenu [passif] génère 10 piécettes par jeu"",
                  ""Verbomoteur [sauvegarde] muet"",
                  ""Discours [parle à la cible pendant 30 secondes] met fin à dominer""
                ]
              ]
            },
            {
              ""title"": ""Marchandage [l]"",
              ""description"": [
                [
                  ""4 blocs de production ou composantes, au choix, par jeu"",
                  ""+2 blocs de production ou composantes, au choix, par jeu"",
                  ""+2 blocs de production ou composantes, au choix, par jeu"",
                  ""+2 blocs de production ou composantes, au choix, par jeu"",
                  ""+2 blocs de production ou composantes, au choix, par jeu""
                ]
              ]
            },
            {
              ""title"": ""Médecine [c]"",
              ""description"": [
                [
                  ""Opération [touché, 30 secondes] retire une <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>nécrose</a>"",
                  ""Suture [touché, 30 secondes] redonne 2 points de vie"",
                  ""Psychiatrie [touché] la cible devient calme"",
                  ""Relaxation [touché, 5 secondes] met fin à muet"",
                  ""Pharmacie [touché, 5 secondes] peut utiliser les médicaments""
                ]
              ]
            },
            {
              ""title"": ""Métier [c]"",
              ""description"": [
                [
                  ""Artisanat [production] filet, corde, baguette, fortification et piège."",
                  ""Forge [production] arme , armure, bouclier, cadenas et engin"",
                  ""Herboristerie [production] médicaments"",
                  ""Spécialiste I : +2 blocs de production à une production existante (sauf alchimie)"",
                  ""Spécialiste II : +2 blocs de production à une production existante (sauf alchimie).""
                ]
              ]
            }
          ]
        }
      ]
    },
    {
      ""title"": ""Production"",
      ""description"": [
        ""Pour produire un objet, un joueur doit écrire sur son bloc de production l’objet qu’il désire créer selon les listes de la présente section. Il doit dépenser un point d’énergie et il doit être hors-combat."",
        ""Il existe deux types d’objet :"",
        [
          ""Consommable [c]: l’objet est détruit après usage. L’objet de jeu est représenté par son carton lors d’un dépouillement"",
          ""Permanent [p] : l’objet n’est pas détruit par l’usage. L’objet de jeu est représenté par une représentation crédible appartenant au joueur lors d’un dépouillement.  Au moment de déposer la représentation au côté du propriétaire, le voleur peut réclamer le carton de jeu à son propriétaire.""
        ]
      ],
      ""section"": [
        {
          ""title"": ""Alchimie"",
          ""description"": [
            ""Il est généralement nécessaire d’appliquer un produit alchimique sur sa lame en la frottant 5 secondes avec une main libre pour en faire usage."",
            [
              ""Poison [c] réduit de 2 points l’énergie de tous ceux qui ingèrent la boisson ou la nourriture contaminée jusqu’à ce qu’un antidote soit administré"",
              ""Toxine [c] nécessaire à l’utilisation de certaines techniques sournoises."",
              ""Venin [c] ajoute 1 point de dégât sur la prochaine touche faite avec l’arme. Cumulatif avec attaque sournoise""
            ]
          ]
        },
        {
          ""title"": ""Artisan"",
          ""description"": [
            [
              ""Baguette [c] : permet, une fois par combat, de payer le coût en composante du dernier rituel mémorisé pour le mémoriser de nouveau. Usage unique"",
              ""Corde [p] : permet de paralyser une cible désarmée. Peut être détruit par une lame"",
              ""Filet [p] : permet de paralyser une cible dont on couvre la tête du filet. Peut être détruit par une lame."",
              ""Fortification [c] : redonne un point de vie à une forteresse. Une forteresse peut avoir jusqu’à 5 points de vie, mais commence le jeu avec 3 points "",
              ""Piège [c] corde avec une clochette : Inflige 2 points de dégât à qui touche la corde quand la clochette sonne.""
            ]
          ]
        },
        {
          ""title"": ""Mixture de potions"",
          ""description"": [
            ""Utiliser une potion demande de boire une gorgée dans un contenant rempli d’un liquide quelconque que le joueur transporte sur lui."",
            [
              ""Fortitude [c] : donne une sauvegarde contre le poison"",
              ""Guérison [c] : guérit 1 point de vie"",
              ""Sagesse [c] : redonne 2 points d’énergie""
            ]
          ]
        },
        {
          ""title"": ""Forgeron"",
          ""description"": [
            [
              ""Armure [c] : permet au forgeron de réparer une armure en combat en 15 secondes"",
              ""Arme [c] : remplace une arme cassée"",
              ""Bouclier [c] : remplace un bouclier cassé"",
              ""Cadenas et clef [p] : empêche l’ouverture d’un coffre sans la clef"",
              ""Engin de siège [p] : inflige 1 point de dégât à une fortification. Une personne touchée par un projectile d’engin de siège est morte. Représenté par une baliste, une catapulte ou un bélier fonctionnel et sécuritaire.""
            ]
          ]
        },
        {
          ""title"": ""Herboriste"",
          ""description"": [
            ""Appliquer un médicament demande de toucher la cible avec une main libre pour 5 secondes et d’avoir la technique pharmacie."",
            [
              ""Baume [c] : guérit 2 points de vie"",
              ""Injection [c] : guérit assommé"",
              ""Antidote [c] : contre les effets d’un poison.""
            ]
          ]
        },
        {
          ""title"": ""Enchantement"",
          ""description"": [
            ""Voici la liste des objets sujets à l’enchantement et l’effet associé."",
            [
              ""Armure [p] : +1 point de vie à la valeur de l’armure. Ne peut plus être utilisée pour faire une réparation"",
              ""Arme [p] : une sauvegarde contre cassé par combat"",
              ""Baguette [p] : peut être utilisée une fois par combat"",
              ""Bouclier [p] : une sauvegarde contre cassé par combat"",
              ""Cadenas [p] : ne peut être ouvert par la technique serrurier"",
              ""Corde [p] : ne peut être détruit par une lame (le nœud doit être défait pour libérer la cible)"",
              ""Engin de siège [p] : inflige 2 points de dégât à une fortification"",
              ""Filet [p] : ne peut être détruit par une lame (le filet doit être retiré de sur sa cible)"",
              ""Fortification [p] : peut être fortifié jusqu’à 10 points de vie.""
            ]
          ]
        }
      ]
    },
    {
      ""title"": ""Rituels de départ"",
      ""description"": [
        ""Au moment de choisir l’habileté rituel, un personnage peut inscrire deux des trois rituels disponibles à son école dans son livre de sort. Il peut faire de même pour l’école de création quand il choisit la technique infusion. Les rituels sont présentés comme suit. Le nombre entre parenthèses est le coût en composantes. Le nom du rituel suit. L’information entre crochets précise la durée et la portée du sort si applicable. La description conclue.""
      ],
      ""section"": [
        {
          ""title"": ""Démonologie"",
          ""description"": [
            [
              ""(4) Possession [jeu, personnel] le personnage accepte un démon en sa chaire. Il doit inclure une mutation à son costume ainsi qu’un motif rouge à son visage. Le joueur choisit une technique parmi toutes les habiletés qui lui sont disponibles et l’ajoute à son personnage."",
              ""(1) Dissipation [touché] met fin à tous les sorts non permanents sur la cible."",
              ""(1) Sacrifice [personnel] l’initiateur peut convertir ses points d’énergie actuels en points de vie, jusqu’à son maximum habituel. Il peut aussi choisir de transformer ses points de vie en énergie, toujours jusqu’à son maximum usuel.""
            ]
          ]
        },
        {
          ""title"": ""Élémentaire"",
          ""description"": [
            [
              ""(2) Peau de pierre [jeu, personnel] l’initiateur doit porter un maquillage gris sur sa peau. La peau de l’initiateur est considérée comme une armure conférant 4 points de vie. Elle se répare avec une composante pendant un repos."",
              ""(1) Combustion [touché] cassé."",
              ""(1) Armes élémentaires [personnel] +1 point de dégât aux 2 prochaines touches.""
            ]
          ]
        },
        {
          ""title"": ""Naturelle"",
          ""description"": [
            [
              ""(4) Armure d’écorces [jeu, personnel] la peau se couvre d’écorces, conférant une armure de 3 points de vie. Le joueur doit porter un maquillage brun ou une représentation d’écorces sur son costume. Réparer l’armure d’écorce coûte un repos."",
              ""(1) Séisme [à vue] la forteresse désignée reçoit 3 points de dégât."",
              ""(1) Camouflage [touché] caché tant qu’immobile.""
            ]
          ]
        },
        {
          ""title"": ""Nécromancie"",
          ""description"": [
            [
              ""(4) Nécromorphose [jeu, personnel] l’initiateur doit porter un maquillage (un motif visible) ou un masque blanc. L’initiateur peut discuter avec les morts. Il est aussi immunisé à la peur et à la domination."",
              ""(1) Animation [touché, joueur mort] revient à la vie en tant que zombie sous la domination de l’initiateur avec 5 points de vie et aucune énergie. Un zombie est sans intelligence et ne peut pas communiquer, utiliser une technique ou retenir d’informations. Quand un zombie tombe assommé ou que 15 minutes se sont écoulées, le joueur se rend au cimetière où il revient à la vie selon les règles normales, mais sans coût de karma."",
              ""(1) Décomposition [touché] <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>nécrose</a>.""
            ]
          ]
        },
        {
          ""title"": ""Protection"",
          ""description"": [
            [
              ""(2) Aura [jeu, personnel] l’initiateur est baigné d’un halo de lumière. Il doit porter un symbole blanc et jaune au visage. Sa peau est considérée comme une armure conférant 2 points de vie et se répare avec le sort réparation."",
              ""(1) Bouclier [touché] la cible gagne un point de vie additionnel."",
              ""(1) Vérité [hors-combat] la cible doit répondre à la prochaine question par la vérité.""
            ]
          ]
        },
        {
          ""title"": ""Création"",
          ""description"": [
            ""L’école de création est un art rituel expérimental. Il permet aux joueurs de créer des objets magiques permanents ou temporaires et certaines formes de bénédictions et de malédictions. Le facteur qui détermine cela est l’objet cible du rituel, qui peut être n’importe quel objet se trouvant dans la section production. La puissance du rituel est à la hauteur du nombre de composantes sacrifiées dans celui-ci, avec le nombre de points de protocole équivalent. Dans un rituel de création, il est possible de remplacer jusqu’à la moitié des composantes requises par des blocs de production. Ces blocs doivent tous être du même type, et orientent le résultat final du rituel. Aucun rituel de création ne fonctionne en dessous de 6 composantes, et un investissement de plus de 30 composantes devrait toujours être associé à une piste en jeu. Tous les détails de l’expérience sont consignés au livre de sort du joueur. L’effet du rituel est déterminé par l’organisation après l’expérience. Le joueur pourra créer le même objet avec le même rituel une fois la première expérience complétée."",
            ""NOTE : Les rituels de création n’offrent aucune garantie. Il est possible de composer deux rituels différents et de finir avec le même effet. Il est aussi possible de maudire son propre personnage à travers un rituel de création.""
          ]
        }
      ]
    },
    {
      ""title"": ""Rituels - Création"",
      ""description"": [
        ""Sous-écoles: Artisanat, Forgeron, Mélange et Liquide, Portail et Zone.""
      ],
      ""section"": [
        {
          ""title"": ""Artisanat"",
          ""description"": ""La sous école Artisanat regroupe les objets créés par l’artisan, en plus des vêtements, accessoires et contenants. Les artisanats magiques sont les outils de stratégie par excellence. Que ce soit pour un plan de kidnapping, un vol de haut niveau ou la sécurité d’un objet précieux, les artisanats magiques ont la solution."",
          ""section"": [
            {
              ""title"": ""Baguette"",
              ""description"": [
                ""<small>(Baguette: Permet, une fois par combat, de payer le coût en composante du dernier rituel mémorisé pour le mémoriser de nouveau. Usage unique.)</small>"",
                ""Une baguette créé par un Rituel de Création permet de stocker un rituel[sort] et de s’en servir plus tard. N’importe qui peut utiliser une baguette «magique» une fois fabriquée. Pour se faire la baguette doit être la cible du Rituel désiré, le faire en suivant ses protocoles et en payer les composantes. Le fabricant de la baguette «magique» n’est pas obligé d’être celui qui connaît le rituel à infuser. Puis, la même baguette doit être au centre du Rituel de Création, en suivre les protocoles et payer 5 fois les composantes magiques du rituel infusé. Il est possible d’augmenter les charges uniques de la baguette en payant chaque fois, 5 fois les composantes magiques du rituel infusé.""
              ]
            },
            {
              ""title"": ""Filet"",
              ""description"": [
                ""<small>(Filet: Permet de paralyser une cible dont on couvre la tête du filet. Peut être cassé par une lame.)</small>"",
                [
                  ""6 - 7 composantes: filet avec effet sur capture"",
                  [
                    ""Aveugle"",
                    ""Foudroyé"",
                    ""Désarmé.""
                  ],
                  ""8 - 9 composantes: filet avec effet sur capture"",
                  [
                    ""Calme"",
                    ""Caché"",
                    ""Muet.""
                  ],
                  ""10 - 11 composantes:"",
                  [
                    ""Dominé (note: la cible est paralysée, mais peut marcher)"",
                    ""Assommé"",
                    ""Immatérielle.""
                  ],
                  ""12 à 15 composantes: Filet avec une capacité extraordinaire"",
                  [
                    ""Affecte l’immatériel"",
                    ""Donne une <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>nécrose</a> sur capture"",
                    ""Drain complet de l’énergie"",
                    ""Animation [consommable] un cadavre se lève en goule sous votre contrôle (10PV, aucune énergie)""
                  ],
                  ""16 à 30 composantes: objets économiques et scénario"",
                  [
                    ""Filet de pêche: génère [composantes/10] rations par jeu"",
                    ""Filet d’esclavagiste: génère [composantes/15] esclaves par jeu"",
                    ""Attrapeur de rêves: génère [composantes/10] blocs d’enchantement par jeu""
                  ]
                ]
              ]
            },
            {
              ""title"": ""Corde"",
              ""description"": [
                ""<small>(Corde: Permet de paralyser une cible désarmée. Peut être détruite par une lame.)</small>"",
                [
                  ""6 - 7 composantes: corde avec effet sur capture"",
                  [
                    ""Aveugle"",
                    ""Foudroyé"",
                    ""Désarmé""
                  ],
                  ""8 - 9 composantes: corde avec effet sur capture"",
                  [
                    ""Calme"",
                    ""Caché"",
                    ""Muet""
                  ],
                  ""10 - 11 composantes: corde avec effet sur capture"",
                  [
                    ""Dominé (note: la cible est paralysée, mais peut marcher)"",
                    ""Assommé"",
                    ""Immatérielle.""
                  ],
                  ""12 à 15 composantes: Filet avec une capacité extraordinaire"",
                  [
                    ""Affecte l’immatériel"",
                    ""Donne une <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>nécrose</a> sur capture"",
                    ""Drain complet de l’énergie""
                  ],
                  ""16 à 30 composantes: objets économiques et scénario"",
                  [
                    ""Corde du pendu: permet de tuer de façon permanente un joueur accusé dans une cours de justice légitime"",
                    ""Collet: génère [composante/10] rations par jeu"",
                    ""Corde infinie: génère [composantes/10] blocs artisanaux par jeu.""
                  ]
                ]
              ]
            },
            {
              ""title"": ""Fortification"",
              ""description"": [
                ""<small>(Fortification: Redonne un point de vie à une forteresse. Une forteresse peut avoir jusqu’à 5 points de vie, mais commence le jeu avec 3.)</small>"",
                [
                  ""6 - 7 composantes: effet à usage unique affectant tout le monde à l’intérieur d’un bâtiment"",
                  [
                    ""Guérison 2"",
                    ""Regain d’énergie 1"",
                    ""Dégât 1"",
                    ""Drain d’énergie 1.""
                  ],
                  ""8 - 9 composantes: effet à usage unique affectant tout le monde à l’intérieur d’une enceinte"",
                  [
                    ""Guérison 2"",
                    ""Regain d’énergie 1"",
                    ""Dégât 1"",
                    ""Drain d’énergie 1.""
                  ],
                  ""10 - 11 composantes: effet à usage unique affectant tout le monde à l’intérieur d’un bâtiment"",
                  [
                    ""Réanimation"",
                    ""Résurrection"",
                    ""Foudroyé"",
                    ""<a target='_self' href='#Mécaniquedebase_Effetsdejeu'>Nécrose</a>""
                  ],
                  ""12 - 13 composantes: effet à usage unique affectant tout le monde à l’intérieur d’une enceinte"",
                  [
                    ""Réanimation"",
                    ""Résurrection"",
                    ""Foudroyé"",
                    ""<a target='_self' href='#Mécaniquedebase_Effetsdejeu'>Nécrose</a>""
                  ],
                  ""14 - 15 composantes: effet permanent affectant tout le monde prenant un repos dans le bâtiment"",
                  [
                    ""Énergie maximum. Perdure jusqu’à utilisation"",
                    ""Répare l’armure (ne fonctionne pas sur les rituels d’armure)"",
                    ""+1 point de vie maximum. Perdure jusqu’à ce que perdu"",
                    ""<a target='_self' href='#Mécaniquedebase_Effetsdejeu'>Nécrose</a>""
                  ],
                  ""16 - 17 composantes: effet permanent affectant tout le monde prenant un repos dans l’enceinte"",
                  [
                    ""Répare l’armure (ne fonctionne pas sur les rituels d’armure)"",
                    ""+1 point de vie maximum. Perdure jusqu’à ce que perdu"",
                    ""<a target='_self' href='#Mécaniquedebase_Effetsdejeu'>Nécrose</a>""
                  ],
                  ""18 - 19 composantes: effet permanent affectant tout le monde prenant un repos dans le bâtiment"",
                  [
                    ""+1 énergie maximum. Perdure jusqu’à utilisation"",
                    ""-1 karma"",
                    ""Répare une armure rituelle.""
                  ],
                  ""20 - 30 composantes: transformation d’un bâtiment en commerce de niveau [(composantes - 15)/5]"",
                  [
                    ""Distillerie"",
                    ""Forge"",
                    ""Atelier"",
                    ""Cercle runique"",
                    ""Laboratoire"",
                    ""Pharmacie.""
                  ]
                ],
                ""*Un bâtiment est une construction qui dispose d’un toit, de quatre murs et d’un plancher"",
                ""**Une enceinte est une construction qui est ceinturée d’un mur, mais qui n’a pas nécessairement un toit. L’organisation peut désigner tout lieu comme étant réputé être une enceinte."",
                ""Par exemple: l’arène.""
              ]
            },
            {
              ""title"": ""Piège"",
              ""description"": [
                ""<small>(Piège: corde avec une clochette. Inflige 2 points de dégât à qui touche la corde quand la clochette sonne)</small>"",
                [
                  ""6 - 7 composantes: piège avec effet additionnel sur déclenchement (l’effet est sur un papier sur la corde)"",
                  [
                    ""Désarmé"",
                    ""Foudroyé"",
                    ""Muet""
                  ],
                  ""8 - 9 composantes: piège avec effet additionnel sur déclenchement (l’effet est sur un papier sur la corde)"",
                  [
                    ""Démembré"",
                    ""Peur"",
                    ""Aveugle""
                  ],
                  ""10 - 11 composantes: piège avec effet additionnel sur déclenchement (l’effet est sur un papier sur la corde)"",
                  [
                    ""Enragé"",
                    ""Calme"",
                    ""Cassé""
                  ],
                  ""12 - 15 composantes: piège avec effet additionnel sur déclenchement (l’effet est sur un papier sur la corde)"",
                  [
                    ""Assommé"",
                    ""Paralysé (5 minutes)"",
                    ""<a target='_self' href='#Mécaniquedebase_Effetsdejeu'>Nécrose</a>""
                  ],
                  ""16 - 20 composantes: Pièges avec faculté extraordinaire"",
                  [
                    ""Ne peut être désarmé"",
                    ""Inflige 4 de dégât"",
                    ""Affecte l’éthéré seulement (le piège est alors représenté par un laser)""
                  ],
                  ""21 à 30 composantes: Pièges à usage économique ou alternatif."",
                  [
                    ""Fausse d’esclavagiste: génère [composantes/15] esclaves par jeu;"",
                    ""Piège de poche: si un token de vol à la tire est inséré dans la même poche que le piège, l’initiateur du vol à la tir tombe assommé"",
                    ""Contingence: permet de lier l’activation d’un rituel à un mot ou un geste.""
                  ]
                ]
              ]
            }
          ]
        },
        {
          ""title"": ""Forgeron"",
          ""description"": [
            ""Cette sous-école rassemble les rituels affectant tous les objets de métal. Elle comprend également les rituels touchant à l’or, l’argent et les métaux spéciaux. La magie des bijoux provient généralement de cette sous-école.""
          ],
          ""section"": [
            {
              ""title"": ""Armures"",
              ""description"": [
                ""<small>(Armure : permet au forgeron de réparer une armure en combat en 15 secondes.)</small>"",
                [
                  ""6 - 18 composantes: effet permanent sur le porteur (c = nombre de composantes)"",
                  [
                    ""+[c/6]karma au début du jeu"",
                    ""-[c/6]karma au début du jeu"",
                    ""+[c/6] points de vie (entre 6 et 9, +0)"",
                    ""+[c/6] énergie maximum (entre 6 et 9, +0);"",
                    ""+[c/6] <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>nécroses</a>;"",
                    ""-[c/6] énergie maximum;""
                  ],
                  ""19 - 20 composantes: protège contre certains assauts"",
                  [
                    ""Protection contre la possession"",
                    ""Protection contre les attaques venant de l’immatériel"",
                    ""Protection contre la perte d’objet quand le joueur devient immatériel""
                  ],
                  ""21 - 30 composantes: armure à signification scénario"",
                  [
                    ""Protection contre le psychisme"",
                    ""Protection contre un environnement hostile:""
                  ],
                  [
                    ""Zone de l’enfer:"",
                    [
                      ""Abadon"",
                      ""Nirvana"",
                      ""Néposd""
                    ],
                    ""Plan élémentaire (eau, terre air ou feu):"",
                    [
                      ""Cosmos"",
                      ""Néant.""
                    ],
                    ""Protection contre les assauts cosmiques.""
                  ]
                ]
              ]
            },
            {
              ""title"": ""Armes"",
              ""description"": [
                ""<small>(<a target='_self' href='#Mécaniquedebase_Mécaniquedecombat_Armesetbouclier'>Arme</a> : remplace une arme cassée)</small>"",
                [
                  ""6 - 7 composantes: imite une technique gratuitement, une fois par combat"",
                  [
                    ""Attaque sournoise"",
                    ""Jambette"",
                    ""Désarmement""
                  ],
                  ""8 - 9 composantes: imite une technique gratuitement, une fois par combat"",
                  [
                    ""Assaut"",
                    ""Coupe-jarret;"",
                    ""Stylet""
                  ],
                  ""10 - 11 composantes: donne accès à une technique, utilisant l’énergie du porteur"",
                  [
                    ""Attaque sournoise"",
                    ""Jambette"",
                    ""Désarmement""
                  ],
                  ""12 - 13 composantes: donne accès à une technique, utilisant l’énergie du porteur"",
                  [
                    ""Assaut"",
                    ""Coupe-jarret"",
                    ""Stylet""
                  ],
                  ""14 - 15 composantes: imite une technique gratuitement, une fois par combat (inclus la toxine)"",
                  [
                    ""Aveuglement"",
                    ""Coup bas"",
                    ""Coup sonnant.""
                  ],
                  ""16 - 20 composantes: l’arme inflige 1 point de dégât additionnel sur un type de créature."",
                  [
                    ""Mort-vivant"",
                    ""Naturel (trucs druidiques)"",
                    ""Nature corrompue (Natueur et cie)"",
                    ""Démons"",
                    ""Gardiens"",
                    ""Anges.""
                  ],
                  ""21 - 30 composantes: Armes à effet sur une touche. Utilise l’énergie du joueur jusqu’à un maximum de [1+((c-20)/5)] fois par combat."",
                  [
                    ""<a target='_self' href='#Mécaniquedebase_Effetsdejeu'>Nécrose</a>"",
                    ""Drain 1 (inflige 1 de dégât et regagne 1 point de vie)"",
                    ""-1 énergie sur la cible"",
                    ""Peur"",
                    ""Calme.""
                  ]
                ]
              ]
            },
            {
              ""title"": ""Bouclier"",
              ""description"": [
                ""<small>(<a target='_self' href='#Mécaniquedebase_Mécaniquedecombat_Armesetbouclier'>Bouclier</a> : remplace un bouclier cassé)</small>"",
                [
                  ""6 - 7 composantes: imite une technique gratuitement, une fois par combat"",
                  [
                    ""Esquive"",
                    ""Déflexion"",
                    ""Déviation""
                  ],
                  ""8 - 9 composantes: imite une technique gratuitement, une fois par combat"",
                  [
                    ""Santé"",
                    ""Second-souffle"",
                    ""Verbomoteur""
                  ],
                  ""10 - 11 composantes: donne accès à une technique, utilisant l’énergie du porteur"",
                  [
                    ""Esquive"",
                    ""Déflexion"",
                    ""Déviation""
                  ],
                  ""12 - 13 composantes: donne accès à une technique, utilisant l’énergie du porteur"",
                  [
                    ""Santé"",
                    ""Second-souffle"",
                    ""Verbomoteur""
                  ],
                  ""14 - 15 composantes: le bouclier prend la forme d’un bijou. Donne accès une technique, utilisant l’énergie du porteur. "",
                  [
                    ""Mensonge"",
                    ""Évasion"",
                    ""Dissimulation"",
                    ""Camouflage""
                  ],
                  ""16 - 20 composantes: Sauvegarde les rituels provenant d’une école de rituel, au coût d’un d’énergie."",
                  [
                    ""Protection"",
                    ""Création"",
                    ""Nécromancie"",
                    ""Démonologie"",
                    ""Élémentaire"",
                    ""Naturel.""
                  ],
                  ""21 - 30 composantes: sauvegarde contre les mécaniques de combat et scénario d’une nature."",
                  [
                    ""École rituel précise"",
                    ""Pouvoir de source infernal"",
                    ""Pouvoir de source divine"",
                    ""Pouvoir de source cosmique"",
                    ""Pouvoir de source druidique"",
                    ""Pouvoir de source naturelle corrompue""
                  ]
                ]
              ]
            },
            {
              ""title"": ""Cadenas"",
              ""description"": [
                ""<small>(Cadenas et clef : empêche l’ouverture d’un coffre sans la clef)</small>"",
                ""Un cadenas magique ne peut être ouvert que par un mot de commande écrit dans une enveloppe dans le coffre qu’il sert à barrer. Pour crocheter le cadenas, il faut d’abord briser l’enchantement. Un mage avec infusion et disjonction doit ramasser un nombre de composantes égal au nombre cumulé pour faire le cadenas et faire un rituel cumulant autant de points de protocole."",
                ""Le cadenas redevient alors normal, et peut être crocheté. Le nombre de composantes investi dans le rituel de création du cadenas doit être clairement indiqué sur la représentation du cadenas. Dès qu’un cadenas magique est créé, la mécanique pour les briser doit faire partie du speech de départ. Le Poste de Traite informe aussi les voleurs curieux de la procédure.""
              ]
            },
            {
              ""title"": ""Engin de siège"",
              ""description"": [
                ""<small>(Engin de siège : inflige 1 de dégât à une fortification. Une personne touchée par un projectile d’engin de siège est morte.)</small>"",
                [
                  ""Inflige 1+[c/6] dégât à une fortification (entre 2 et 6). Cumulable avec l’effet d’un enchantement.""
                ]
              ]
            },
            {
              ""title"": ""Joyaux"",
              ""description"": [
                ""<small>(Joyau : effets scénario divers. Limite de 3 joyaux par personnage dans un même jeu)</small>"",
                [
                  ""6 - 7 composantes: effet sur le porteur, instantané, une fois par jeu."",
                  [
                    ""+1 karma"",
                    ""Guérison 2 points"",
                    ""Regain de 2 d’énergie""
                  ],
                  ""8 - 9 composantes: effets économique mineur"",
                  [
                    ""Génère 1 bloc par jeu"",
                    ""Génère 10 pièces par jeu"",
                    ""Génère 1 composante par jeu""
                  ],
                  ""10 - 11 composantes: effet au touché, instantané, une fois par jeu."",
                  [
                    ""Muet"",
                    ""Aveugle"",
                    ""Démembré.""
                  ],
                  ""12 - 13 composantes: technique octroyée au porteur"",
                  [
                    ""Mensonge"",
                    ""Résilience"",
                    ""Loyauté""
                  ],
                  ""14 - 15 composantes: effet permanent sur le porteur"",
                  [
                    ""Protection contre l’animation"",
                    ""Protection contre la possession"",
                    ""+2 points de vie quand ne porte pas d’armure""
                  ],
                  ""16 - 30 composantes: effet économique majeur"",
                  [
                    ""Génère [c/10] blocs, au choix, par jeu"",
                    ""Génère 1 + [c/10] composantes par jeu"",
                    ""Génère [c/10] pierres d’âme par jeu;"",
                    ""Génère [c/5] pierres de sanglite par jeu"",
                    ""Génère [c/5] pierres de bluame par jeu"",
                    ""Génère [c/5] pierres de malachite par jeu""
                  ]
                ]
              ]
            }
          ]
        },
        {
          ""title"": ""Mélanges et Liquides"",
          ""description"": [
            ""Cette sous-école correspond aux habiletés d’alchimie, herboristerie et concoctions de potion. Les rituels à base d’un objet d'alchimie crée des maladies. Les rituels à base d’herboristerie crée des antidotes et des remèdes aux maladies magiques. Les rituels à base de potion sont quand à eux variés, certains permettent d'améliorer une potion à des niveaux de magie hallucinante, d’autres de provoquer des effets spectaculaires et uniques.""
          ],
          ""section"": [
            {
              ""title"": ""Alchimie"",
              ""description"": [
                ""<small>(Ressources : champignon, venin ou plante. Poison: réduit de 2 l’énergie. Toxine: foudroie, Venin: ajoute 1 de dégât.)</small>"",
                ""Légende :"",
                [
                  ""[Sang] Transmise quand on touche le joueur assommé ou mort."",
                  ""[Air] Transmise quand le joueur touche à main nue la peau d’un autre joueur."",
                  ""[Salive] Transmise quand un joueur partage de la nourriture ou un breuvage."",
                  ""[Famine] Un joueur est infecté pour chaque point en carence alimentaire dans la géopolitique (selon leur faction)."",
                  ""[6] Peste commune: [sang] 1 <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>nécrose</a> inopérable."",
                  ""[6] Spore parasite: [air] - 2 à l’énergie."",
                  ""[6] Grippe: [air] -2 au karma."",
                  ""[8] Peste noire: [sang] 2 <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>nécroses</a> inopérables."",
                  ""[8] Spore débilitant: [salive] -4 à l’énergie."",
                  ""[8] Choléra: [salive] -4 au karma."",
                  ""[10] Peste Figaro: [sang] 3 <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>nécroses</a> inopérables."",
                  ""[10] Démence: [famine] -6 à l’énergie."",
                  ""[10] Malédiction: [famine] -6 au karma."",
                  ""[15] Virus de Valcenne: [air] 1 <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>nécrose</a> inopérable, -2 à l’énergie et au karma."",
                  ""[15] Bactérie cannibale: [sang] 2 <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>nécroses</a> inopérables et -4 au karma."",
                  ""[15] Décomposition nerveuse: [famine] 2 <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>nécroses</a> inopérables et -4 à l’énergie."",
                  ""[15] Dépression: [famine] -4 karma et énergie."",
                  ""[20] Lèpre: [sang] 2 <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>nécroses</a> inopérables, -4 à l’énergie et au karma."",
                  ""[20] Cancer: [famine] 3 <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>nécroses</a> inopérables et -6 au karma."",
                  ""[20] Bactérie nervophage: [salive] 3 <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>nécroses</a> inopérables et -6 à l’énergie."",
                  ""[20] <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>Nécrose</a> de l’âme: [famine] -6 à l’énergie et au karma."",
                  ""[30] Vengeance de Finosia: [sang] 3 <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>nécroses</a> inopérables, -6 au karma et à l’énergie."",
                  ""[30] Drain de l’âme: [famine] Ne peut pas utiliser de techniques.""
                ]
              ]
            },
            {
              ""title"": ""Herboristerie"",
              ""description"": [
                ""<small>(Ressources : calmant, stimulant et contrepoison. Baume : guérit 2 points de vie. Injection : guérit assommé. Antidote : contrepoison.)</small>"",
                ""Les rituels avec les médicaments permettent de guérir les gens des maladies créées par les rituels de création sur l’alchimie. La force doit être équivalente à celle utilisée pour créer la maladie. Le rituel crée une recette qu’un herboriste peut utiliser pour synthétiser un bloc de production en remède pour la maladie précise. Chaque fois que le rituel est répété, il est possible d’enseigner la recette à un autre herboriste."",
                ""Le rituel va toujours donner le bon remède si le joueur peut identifier la maladie et la puissance nécessaire pour la révoquer. Un joueur peut aussi essayer de transformer un remède sans connaître de maladie. À ce moment, le joueur apprend une recette au hasard capable de soigner une des maladies de la liste alchimie. Appliquer la maladie la plus près en puissance.""
              ]
            },
            {
              ""title"": ""Potions"",
              ""description"": [
                ""<small>(Ressources : philtre, poudre et essence. Fortitude: une sauvegarde poison. Guérison : guérit 1 pv. Sagesse : redonne 2 d’énergie.)</small>"",
                ""Les potions utilisées en rituel de création permettent de bénir un certain nombre de participants pour la durée du jeu, à moins d’avertissement contraire. Les avantages ne peuvent pas surpasser les maximums établis du système. Certains rituels font effet dès qu’ils sont terminés, d’autres permettent de garder l’effet en bouteille."",
                ""Légende:"",
                [
                  ""[bénédiction] L’effet du rituel est instantané et affecte le nombre de joueurs inscrits dans la description."",
                  ""[bouteille] Le rituel se conserve en bouteille et doit être bu pour faire effet."",
                  ""[6] Nuit liquide: [bouteille] Usage unique. Une fois lancée au sol, la fiole libère un nuage de noirceur qui aveugle toutes les cibles dans un rayon de 5 pas de la bouteille. (Utiliser une bouteille incassable)"",
                  ""[6] Bénédiction I: [bénédiction] +1 point de vie pour 3 personnes."",
                  ""Méditation I: [bénédiction] +1 énergie pour 3 personnes."",
                  ""[6] Prière I: [bénédiction] +2 karma pour 3 personnes."",
                  ""[8] Bénédiction I: [bénédiction] +1 point de vie pour 6 personnes."",
                  ""[8] Méditation I: [bénédiction] +1 énergie pour 6 personnes."",
                  ""[8] Prière I: [bénédiction] +2 karma pour 6 personnes."",
                  ""[10] Bénédiction I: [bénédiction] +1 point de vie pour 9 personnes."",
                  ""[10] Méditation I: [bénédiction] +1 énergie pour 9 personnes."",
                  ""[10] Prière I: [bénédiction] +2 karma pour 9 personnes."",
                  ""[15] Bénédiction II: [bénédiction] +2 points de vie pour 3 personnes."",
                  ""[15] Méditation II: [bénédiction] +2 énergie pour 3 personnes."",
                  ""[15] Prière II: [bénédiction] +4 karma pour 3 personnes."",
                  ""[20] Bénédiction II: [bénédiction] +2 points de vie pour 6 personnes."",
                  ""[20] Méditation II: [bénédiction] +2 énergie pour 6 personnes."",
                  ""[20] Prière II: [bénédiction] +4 karma pour 6 personnes."",
                  ""[25] Bénédiction II: [bénédiction] +2 points de vie pour 9 personnes."",
                  ""[25] Méditation II: [bénédiction] +2 énergie pour 9 personnes."",
                  ""[25] Prière II: [bénédiction] +4 karma pour 9 personnes."",
                  ""[20] Bénédiction III: [bénédiction] +3 points de vie pour 3 personnes."",
                  ""[20] Méditation III: [bénédiction] +3 énergie pour 3 personnes."",
                  ""[20] Prière III: [bénédiction] +6 karma pour 3 personnes."",
                  ""[30] Bénédiction III: [bénédiction] +3 points de vie pour 6 personnes."",
                  ""[30] Méditation III: [bénédiction] +3 énergie pour 6 personnes."",
                  ""[30] Prière III: [bénédiction] +6 karma pour 6 personnes."",
                  ""[40] Bénédiction III: [bénédiction] +3 points de vie pour 9 personnes."",
                  ""[40] Méditation III: [bénédiction] +3 énergie pour 9 personnes."",
                  ""[40] Prière III: [bénédiction] +6 karma pour 9 personnes."",
                  ""[30] Gloire: [bénédiction] +1 point de vie, +1 d’énergie et +2 karma pour tous les participants."",
                  ""[30] Pouvoir de Brokrand: [bénédiction] +2 points de vie et +2 d’énergie pour tous les participants."",
                  ""[30] Lumière d’Eccani: [bénédiction] +2 d’énergie et +4 karma pour tous les participants."",
                  ""[30] Force de Nox: [bénédiction] +2 points de vie et +4 karma pour tous les participants.""
                ]
              ]
            }
          ]
        }
      ]
    },
    {
      ""title"": ""Rituel"",
      ""description"": ""Les rituels sont divisés en 5 écoles et sous-école : Démonologie, Élémentaire, Nature, Nécromantie et Protection."",
      ""section"": [
        {
          ""title"": ""Démonologie"",
          ""under_level_color"": ""panel-danger"",
          ""section"": [
            {
              ""title"": ""Possession"",
              ""section"": [
                {
                  ""description"": [
                    ""Augmente les points de vie à 10, donne accès à la technique Décapitation. "",
                    [
                      ""Coût : 6"",
                      ""Durée : 1 combat"",
                      ""Type : Rage""
                    ],
                    ""Frénésie non-sauvegardable""
                  ],
                  ""title"": ""Le dévoreur de tête""
                },
                {
                  ""description"": [
                    ""Confère 4 point de vie de type armure. Réparable avec une composante magique (hors-combat)."",
                    [
                      ""Coût : 12"",
                      ""Durée : 24h"",
                      ""Type : Bonus""
                    ],
                    ""Silence durant toute la possession et maquillage gris ou masque.""
                  ],
                  ""title"": ""La dame de fer""
                },
                {
                  ""description"": [
                    ""Donne les techniques: Assaut, Résilience, Endurcie et Coup-bas pour la durée du rituel. 1 composante par bénéficiaire."",
                    [
                      ""Coût : 4+\n"",
                      ""Durée : 1 combat"",
                      ""Type : Bonus""
                    ],
                    ""Frénésie non-sauvegardable. 1 crâne(mort) par bénéficiaire.""
                  ],
                  ""title"": ""Le crâne rieur""
                },
                {
                  ""description"": [
                    ""Donne les 5 techniques de l'habileté Sorcellerie.  Permet de faire 2 techniques de Sorcellerie gratuitement par combat."",
                    [
                      ""Coût : 25"",
                      ""Durée : 24h"",
                      ""Type : Bonus""
                    ],
                    ""Le maximum de point de vie possible du personnage est maintenant de 8 (et non 10).""
                  ],
                  ""title"": ""Sorcier des enfers""
                },
                {
                  ""description"": [
                    ""Permet une fois/combat de faire un Aveuglement de masse. Immunise à aveuglement."",
                    [
                      ""Coût : 12"",
                      ""Durée : 24h"",
                      ""Type : Bonus""
                    ],
                    ""Doit éviter la lumière en tout temps.""
                  ],
                  ""title"": ""L'Ombre noire""
                },
                {
                  ""description"": [
                    ""Donne accès à une technique Sournoise (max 5)"",
                    [
                      ""Coût : (# habileté) X 6"",
                      ""Durée : 24h"",
                      ""Type : Bonus""
                    ],
                    ""Les techniques ne peuvent pas changer durant la possession.""
                  ],
                  ""title"": ""Diablotin""
                },
                {
                  ""description"": [
                    ""Donne accès à une technique Combattante (max 5)"",
                    [
                      ""Coût : (# habileté) X 6"",
                      ""Durée : 24h"",
                      ""Type : Bonus""
                    ],
                    ""Les techniques ne peuvent pas changer durant la possession.""
                  ],
                  ""title"": ""Calambin""
                },
                {
                  ""description"": [
                    ""Donne accès à une technique Magique (max 5)"",
                    [
                      ""Coût : (# habileté) X 6"",
                      ""Durée : 24h"",
                      ""Type : Bonus""
                    ],
                    ""Les techniques ne peuvent pas changer durant la possession.""
                  ],
                  ""title"": ""Arcaniste""
                },
                {
                  ""description"": [
                    ""Donne accès à une technique Professionnelle (max 5)"",
                    [
                      ""Coût : (# habileté) X 6"",
                      ""Durée : 24h"",
                      ""Type : Bonus""
                    ],
                    ""Les techniques ne peuvent pas changer durant la possession.""
                  ],
                  ""title"": ""Incube""
                }
              ]
            },
            {
              ""title"": ""Contrat"",
              ""section"": [
                {
                  ""description"": [
                    ""Permet de signer un contrat aux conséquences magiques pour 2 personnes."",
                    [
                      ""Coût : 4"",
                      ""Durée : 1 saison max"",
                      ""Type : Deal""
                    ],
                    ""Conséquence pré-établie.""
                  ],
                  ""title"": ""Contrat Mineur""
                },
                {
                  ""description"": [
                    ""Permet de signer un contrat aux conséquences magiques pour 4 personnes ou moins."",
                    [
                      ""Coût : 8"",
                      ""Durée : 1 saison max"",
                      ""Type : Deal""
                    ],
                    ""Conséquence pré-établie.""
                  ],
                  ""title"": ""Contrat Moyen""
                },
                {
                  ""description"": [
                    ""Permet de signer un contrat aux conséquences magiques pour 10 personnes ou moins."",
                    [
                      ""Coût : 16"",
                      ""Durée : 1 saison max"",
                      ""Type : Deal""
                    ],
                    ""Conséquence pré-établie.""
                  ],
                  ""title"": ""Contrat Majeur""
                },
                {
                  ""description"": [
                    ""Permet de signer un contrat aux conséquences magiques pour 2 factions."",
                    [
                      ""Coût : 30"",
                      ""Durée : 1 saison max"",
                      ""Type : Deal""
                    ],
                    ""Conséquence pré-établie.""
                  ],
                  ""title"": ""Contrat de Faction""
                },
                {
                  ""description"": [
                    ""Permet de créer un contrat de paiement auto-magiquement effectué."",
                    [
                      ""Coût : 6"",
                      ""Durée : Payment total"",
                      ""Type : Deal""
                    ],
                    ""Conséquence pré-établie.  Paiement au début du jeu à l'acceuil sinon vous subissez les conséquences.""
                  ],
                  ""title"": ""Contrat monétaire""
                },
                {
                  ""description"": [
                    ""Permet de tuer Permanent un joueur de SA faction après un procès."",
                    [
                      ""Coût : 50"",
                      ""Durée : Mort Permanente"",
                      ""Type : Effet""
                    ]
                  ],
                  ""title"": ""Arrêt de Mort""
                },
                {
                  ""description"": [
                    ""Permet de rendre une page magique pour chaque 4 composantes investies. Chaque signature sur ces pages permet de poser une question hors-jeu sur le joueur."",
                    [
                      ""Coût : x4"",
                      ""Durée : 1 utilisation"",
                      ""Type : Bonus""
                    ],
                    ""Avoir la vraie signature sur un papier physique. Le papier doit être enchanté avant de recevoir la signature. ""
                  ],
                  ""title"": ""Signature""
                }
              ]
            }
          ]
        },
        {
          ""title"": ""Élémentaire"",
          ""under_level_color"": ""panel-warning"",
          ""section"": [
            {
              ""title"": ""Terre"",
              ""section"": [
                {
                  ""description"": [
                    ""La cible est paralysée et immunisée aux dégâts jusqu’à ce qu’elle subisse 6 touches ou que 10 minutes se soient écoulées."",
                    [
                      ""Coût : 6"",
                      ""Durée : 1 utilisation"",
                      ""Type : Effet""
                    ],
                    ""Toucher""
                  ],
                  ""title"": ""Pétrification""
                },
                {
                  ""description"": [
                    ""Permet de générer 1 bloc de Forgeron, +1 bloc par composante utilisée (maximum 6 composantes pour 5 blocs)."",
                    [
                      ""Coût : 2+"",
                      ""Durée : Instantanée"",
                      ""Type : Production""
                    ]
                  ],
                  ""title"": ""Prospection""
                },
                {
                  ""description"": [
                    ""Transforme des blocs d'Artisant en bloc de Forgeron (max 20)"",
                    [
                      ""Coût : 3"",
                      ""Durée : Instantanée"",
                      ""Type : Production""
                    ]
                  ],
                  ""title"": ""Minéralisation""
                },
                {
                  ""description"": [
                    ""Donne accès à l'habileté Sorcellerie: Gravité pour la durée du rituel. Effet: Foudroyé."",
                    [
                      ""Coût : 12"",
                      ""Durée : Permanent"",
                      ""Type : Bonus""
                    ]
                  ],
                  ""title"": ""Gravité""
                },
                {
                  ""description"": [
                    ""Permet d'achever ses victimes sans perdre de point de karma (maximum de 10 achevements)."",
                    [
                      ""Coût : 8"",
                      ""Durée : 1 combat"",
                      ""Type : Bonus""
                    ],
                    ""-3 karma au lancement du sort.""
                  ],
                  ""title"": ""Coeur de pierre""
                },
                {
                  ""description"": [
                    ""Rend immunisé à Foudroyé ou tout effet déplaçant le personnage contre son gré."",
                    [
                      ""Coût : 2"",
                      ""Durée : 1 combat"",
                      ""Type : Bonus""
                    ]
                  ],
                  ""title"": ""Jambe de roc""
                },
                {
                  ""description"": [
                    ""Permet de faire tomber une météorite à proximité.  La météorite peut être composée de Bluam, de Malachite ou de Sanglite, mais il n'y a aucune manière de le choisir."",
                    [
                      ""Coût : 25"",
                      ""Durée : Instantanée"",
                      ""Type : Effet""
                    ],
                    ""Doit avertir l'organisation avant de faire le rituel. Doit inclure un feu d'artifice""
                  ],
                  ""title"": ""Pluie de météore""
                }
              ]
            },
            {
              ""title"": ""Feu"",
              ""section"": [
                {
                  ""description"": [
                    ""Donne la capacité de produire de la lumière avec un objet décorum."",
                    [
                      ""Coût : 1"",
                      ""Durée : 24h"",
                      ""Type : Bonus""
                    ]
                  ],
                  ""title"": ""Lumière""
                },
                {
                  ""description"": [
                    ""Détruit un objet ni magique, ni enchanté. N’affecte pas les bâtiments (forteresse, commerce, etc…)."",
                    [
                      ""Coût : 1"",
                      ""Durée : 1 utilisation"",
                      ""Type : Bonus""
                    ]
                  ],
                  ""title"": ""Incinération""
                },
                {
                  ""description"": [
                    ""Permet de lancer 3 projectiles qui font 3 points de dégât chacun."",
                    [
                      ""Coût : 2"",
                      ""Durée : 1 utilisation"",
                      ""Type : Bonus""
                    ]
                  ],
                  ""title"": ""Rayons Ardents""
                },
                {
                  ""description"": [
                    ""Permet d'infliger 1 point de dégât à toute personne se trouvant sous le même toît."",
                    [
                      ""Coût : 3"",
                      ""Durée : 1 utilisation"",
                      ""Type : Effet""
                    ]
                  ],
                  ""title"": ""Fumigation""
                },
                {
                  ""description"": [
                    ""Permet d'infliger 3 points de dégât à toute personne se trouvant sous le même toît."",
                    [
                      ""Coût : 8"",
                      ""Durée : 1 utilisation"",
                      ""Type : Effet""
                    ],
                    ""Doit utiliser un fumigène.""
                  ],
                  ""title"": ""Fumée Ardente""
                },
                {
                  ""description"": [
                    ""Donne la technique Sorcellerie:Boule de feu pour la durée du rituel. Effet: 3 points de dégât"",
                    [
                      ""Coût : 3"",
                      ""Durée : 1 combat"",
                      ""Type : Bonus""
                    ],
                    ""Doit se maquiller les mains rouges.""
                  ],
                  ""title"": ""Boule de Feu""
                },
                {
                  ""description"": [
                    ""Permet de détruire un cadavre et de l'envoyer directement au cimetière."",
                    [
                      ""Coût : 2"",
                      ""Durée : 1 utilisation"",
                      ""Type : Effet""
                    ],
                    ""Doit utiliser un corps mort (achevé).""
                  ],
                  ""title"": ""Crémation""
                },
                {
                  ""description"": [
                    ""Permet à la fin d'un combat de brûler tous les cadavres d'un champ de bataille, les envoyant tous directement au cimetière."",
                    [
                      ""Coût : 25"",
                      ""Durée : 1 utilisation"",
                      ""Type : Effet""
                    ],
                    ""Doit utiliser un corp mort (achevé).""
                  ],
                  ""title"": ""Bûcher Funéraire""
                }
              ]
            },
            {
              ""title"": ""Air"",
              ""section"": [
                {
                  ""description"": [
                    ""Donne la technique Sorcellerie:Bourrasque pour la durée du rituel. Effet: la cible recule de 10 pas (comme terreur, mais pas de sauvegarde)."",
                    [
                      ""Coût : 3"",
                      ""Durée : 1 combat"",
                      ""Type : Bonus""
                    ]
                  ],
                  ""title"": ""Bourrasque""
                },
                {
                  ""description"": [
                    ""Au toucher, permet de Paralyser une cible, le lanceur et la personne ciblée sont paralysées. Le lanceur peut mettre fin au sort quand il le désire."",
                    [
                      ""Coût : 2"",
                      ""Durée : 1 utilisation"",
                      ""Type : Bonus""
                    ]
                  ],
                  ""title"": ""Contact Paralysant""
                },
                {
                  ""description"": [
                    ""Le lanceur inflige 2 points de dégât avec une arme de son choix. Cet effet ne peut être jumelé avec aucune autre technique ou rituel, incluant les techniques demandant de cibler avec une arme tel qu’assaut, jambette ou attaque sournoise."",
                    [
                      ""Coût : 6"",
                      ""Durée : 1 combat"",
                      ""Type : Bonus""
                    ],
                    ""L'arme doit porter un foulard ou un ruban jaune.""
                  ],
                  ""title"": ""Électrification""
                },
                {
                  ""description"": [
                    ""Permet d'envoyer un message à n'importe quel NPC."",
                    [
                      ""Coût : 4"",
                      ""Durée : 1 lettre"",
                      ""Type : Effet""
                    ],
                    ""Doit fournir une lettre de maximum 100 mots.""
                  ],
                  ""title"": ""Messager du vent""
                },
                {
                  ""description"": [
                    ""Crée un cercle de protection contre les projectiles de 2 mètres de diamètre. Tous ceux dans la zone reçoivent toujours 0 point de dégât des projectiles, incluant les sort de dégât avec balle."",
                    [
                      ""Coût : 5"",
                      ""Durée : cercle"",
                      ""Type : Effet""
                    ],
                    ""Le cercle doit rester intact.""
                  ],
                  ""title"": ""Colonne de Vent""
                }
              ]
            },
            {
              ""title"": ""Eau"",
              ""section"": [
                {
                  ""description"": [
                    ""Permet de générer 1 bloc de Potion, +1 bloc par composante utilisée (maximum 6 composantes pour 5 blocs)."",
                    [
                      ""Coût : 2+"",
                      ""Durée : 1 utilisation"",
                      ""Type : Production""
                    ]
                  ],
                  ""title"": ""Infusion magique""
                },
                {
                  ""description"": [
                    ""Le lanceur est Immatériel tant qu’il suit un cours d’eau."",
                    [
                      ""Coût : 1"",
                      ""Durée : 1 utilisation"",
                      ""Type : Effet""
                    ],
                    ""Doit rester à 1m ou moins du cours d'eau.""
                  ],
                  ""title"": ""Forme Aquatique""
                },
                {
                  ""description"": [
                    ""Affecte un contenant. Si une personne boit le liquide, il meurt sur le champ. Jeté sur la peau, le liquide inflige 3 points de dégât. N’affecte pas plus que l’équivalent d’un verre de la taverne."",
                    [
                      ""Coût : 5"",
                      ""Durée : 1 utilisation"",
                      ""Type : Effet""
                    ],
                    ""Doit obligatoirement être un liquide H-J.""
                  ],
                  ""title"": ""Fiole d'Acide""
                },
                {
                  ""description"": [
                    ""Une lance devient en glace et frappe maintenant de 2 points de dégât."",
                    [
                      ""Coût : 5"",
                      ""Durée : 1 combat"",
                      ""Type : Bonus""
                    ],
                    ""La lance doit porter un foulard ou un ruban bleu.""
                  ],
                  ""title"": ""Lance de Glace""
                },
                {
                  ""description"": [
                    ""Au toucher la cible du sort est Paralysée pendant 30 secondes."",
                    [
                      ""Coût : 3"",
                      ""Durée : 1 utilisation"",
                      ""Type : Effet""
                    ]
                  ],
                  ""title"": ""Toucher Glacial""
                },
                {
                  ""description"": [
                    ""Rend une personne immunisée à l'achèvement."",
                    [
                      ""Coût : 5"",
                      ""Durée : 1 combat"",
                      ""Type : Bonus""
                    ]
                  ],
                  ""title"": ""Coeur de Glace""
                }
              ]
            }
          ]
        },
        {
          ""title"": ""Nature"",
          ""under_level_color"": ""panel-success"",
          ""section"": [
            {
              ""title"": ""Métamorphose"",
              ""section"": [
                {
                  ""description"": [
                    ""Donne l'équivalent de 2 armes (armes naturelles) qui ne peuvent être désarmées. Peut être réparé par un sort de guérison."",
                    [
                      ""Coût : 6"",
                      ""Durée : Permanent"",
                      ""Type : Bonus""
                    ],
                    ""Implique une modification au costume.""
                  ],
                  ""title"": ""Appel du totem""
                }
              ]
            },
            {
              ""title"": ""Métamorphose"",
              ""section"": [
                {
                  ""description"": [
                    "" +1 point de vie ou 1 sauvegarde par combat contre la paralysie."",
                    [
                      ""Coût : 10"",
                      ""Durée : Permanent"",
                      ""Type : Bonus""
                    ],
                    ""Implique une modification au costume.""
                  ],
                  ""title"": ""Incarnation totémique""
                },
                {
                  ""description"": [
                    [
                      ""Ailes/Queue : sauvegarde Foudroyé"",
                      ""Bec/Museau : +2 blocs d'Alchimie par jeu"",
                      ""Yeux perçant : Donne la technique Vigilance"",
                      ""Branchies [croise les bras] : peut se cacher quand il touche à un court d’eau"",
                      ""Diurne: Donne la technique Camouflage"",
                      ""Nocturne: Donne la technique Dissimulation"",
                      ""Herbivore : + 2 blocs d’Herboristerie par jeu"",
                      ""Carnivore : + 1 ration par jeu"",
                      ""Omnivore : + 2 blocs d'Artisanat par jeu.""
                    ],
                    [
                      ""Coût : 20"",
                      ""Durée : Permanent"",
                      ""Type : Bonus""
                    ],
                    ""Implique une modification au costume.""
                  ],
                  ""title"": ""Aspect animal""
                },
                {
                  ""description"": [
                    ""Donne un deuxième pouvoir selon la liste."",
                    [
                      ""Coût : 35"",
                      ""Durée : Permanent"",
                      ""Type : Bonus""
                    ],
                    ""Implique une modification au costume.""
                  ],
                  ""title"": ""Aspect animal 2""
                },
                {
                  ""description"": [
                    ""Le joueur est de type animal en permanence. Il est sujet à la magie naturelle affectant les animaux. Il gagne 1 point de vie additionnel et la capacité de supprimer son apparence animale à volonté. Quand il reprend une forme humaine, le druide perd accès à ses habiletés de métamorphose, incluant l’apothéose."",
                    [
                      ""Coût : 50"",
                      ""Durée : Permanent"",
                      ""Type : Bonus""
                    ],
                    ""Implique une modification au costume.""
                  ],
                  ""title"": ""Apothéose""
                }
              ]
            },
            {
              ""title"": ""Flore"",
              ""section"": [
                {
                  ""description"": [
                    ""Permet de générer 1 bloc d’herboristerie, +1 bloc par composante utilisée (maximum 6 composantes pour 5 blocs)."",
                    [
                      ""Coût : 2+"",
                      ""Durée : Instantanée"",
                      ""Type : Production""
                    ]
                  ],
                  ""title"": ""Pousses Prodigieuses""
                },
                {
                  ""description"": [
                    ""Permet de générer 1 bloc d'Alchimie, +1 bloc par composante utilisée (maximum 6 composantes pour 5 blocs)."",
                    [
                      ""Coût : 2+"",
                      ""Durée : Instantanée"",
                      ""Type : Production""
                    ]
                  ],
                  ""title"": ""Toxicité""
                },
                {
                  ""description"": [
                    ""+1 ration par jeu."",
                    [
                      ""Coût : 20"",
                      ""Durée : Permanent"",
                      ""Type : Production""
                    ],
                    ""Doit avoir des éléments végétaux sur le costume.""
                  ],
                  ""title"": ""Forme Végétale""
                },
                {
                  ""description"": [
                    ""Donne 2 blocs d'Herboristerie et 2 blocs d'Alchimie"",
                    [
                      ""Coût : 20"",
                      ""Durée : Permanent"",
                      ""Type : Production""
                    ],
                    ""Doit avoir des éléments végétaux sur le costume.""
                  ],
                  ""title"": ""Forme Fongique""
                },
                {
                  ""description"": [
                    ""Confère 4 points de vie de type armure. Réparable avec une composante magique (hors-combat)."",
                    [
                      ""Coût : 12"",
                      ""Durée : Permanent"",
                      ""Type : Production""
                    ],
                    ""*(Prérequis)Forme Végétale ou Fongique""
                  ],
                  ""title"": ""Armure végétale""
                },
                {
                  ""description"": [
                    ""Donne la technique Camouflage."",
                    [
                      ""Coût : 1"",
                      ""Durée : Jusqu'à un déplacement"",
                      ""Type : Bonus""
                    ],
                    ""Rester immobile""
                  ],
                  ""title"": ""Camouflage""
                },
                {
                  ""description"": [
                    ""Permet de poser une question à un végétal légendaire (ex: la racine mère ou le père champignon), pour connaître un rituel végétal, une recette alchimique ou d'herboristerie."",
                    [
                      ""Coût : 15"",
                      ""Durée : Instantanée"",
                      ""Type : Effet""
                    ],
                    ""Ne peux être fait qu'une fois par jeu.""
                  ],
                  ""title"": ""Communion avec les plantes""
                }
              ]
            },
            {
              ""title"": ""Faune"",
              ""section"": [
                {
                  ""description"": [
                    ""Donne une apparence animal à une cible.  La cible peut maintenant être affectée par les sorts qui affectent les animaux."",
                    [
                      ""Coût : 3"",
                      ""Durée : 1 combat"",
                      ""Type : Bonus""
                    ],
                    ""Costume obligatoire""
                  ],
                  ""title"": ""Métamorphose temporaire""
                },
                {
                  ""description"": [
                    ""Permet d'apposer une marque de chasseur.  La cible de la marque ne peut plus utiliser de technique ou de pouvoir pour devenir invisible ou dissimulé."",
                    [
                      ""Coût : "",
                      ""Durée : Jusqu'à ce que la cible soit assomée"",
                      ""Type : Bonus""
                    ],
                    ""Toucher""
                  ],
                  ""title"": ""Chasse""
                },
                {
                  ""description"": [
                    ""Immunise à l'effet Aveugle."",
                    [
                      ""Coût : 8"",
                      ""Durée : Jeu"",
                      ""Type : Bonus""
                    ]
                  ],
                  ""title"": ""Flaire""
                },
                {
                  ""description"": [
                    ""Permet de faire un rugissement; Tout le monde qui entend le rugissement est Apeuré (Peur). (Après avoir crié très fort)"",
                    [
                      ""Coût : 25"",
                      ""Durée : Instantanée"",
                      ""Type : Effet""
                    ]
                  ],
                  ""title"": ""Rugissement""
                }
              ]
            }
          ]
        },
        {
          ""title"": ""Nécromantie"",
          ""under_level_color"": ""panel-primary"",
          ""section"": [
            {
              ""title"": ""Animation"",
              ""section"": [
                {
                  ""description"": [
                    ""Permet d'animer un squelette. Le squelette a 3 points de vie."",
                    [
                      ""Coût : 1"",
                      ""Durée : Jusqu'à la mort"",
                      ""Type : Animation""
                    ],
                    ""Doit utiliser un corp mort (achevé). Le mort est détruit une fois à 0 pv et va directement au cimetière.""
                  ],
                  ""title"": ""Squelette""
                },
                {
                  ""description"": [
                    ""Permet d'animer une goule.  La goule a 10 points vie et peut utiliser ses armes."",
                    [
                      ""Coût : 2"",
                      ""Durée : Jusqu'à la mort"",
                      ""Type : Animation""
                    ],
                    ""Doit utiliser un corp mort (achevé). Le mort est détruit une fois a 0 pv et va directement au cimetière.""
                  ],
                  ""title"": ""Goule""
                },
                {
                  ""description"": [
                    ""Comme une goule, mais avec 2 points d'énergie en plus. Peut récupérer 1 point d'énergie en mangeant une victime pendant 5 secondes. Obtient assault."",
                    [
                      ""Coût : 3"",
                      ""Durée : Jusqu'à la mort"",
                      ""Type : Animation""
                    ],
                    ""Doit utiliser un corp mort (achevé). Le mort est détruit une fois a 0 pv et va directement au cimetière.""
                  ],
                  ""title"": ""Goule cannibale""
                },
                {
                  ""description"": [
                    ""Permet d'animer une momie.  Les statistiques d'une momie sont les mêmes que le joueur animé en momie."",
                    [
                      ""Coût : 5"",
                      ""Durée : Jusqu'à la mort"",
                      ""Type : Animation""
                    ],
                    ""Doit utiliser un corp mort (achevé). Le mort est détruit une fois a 0 pv et va directement au cimetière.""
                  ],
                  ""title"": ""Momie""
                },
                {
                  ""description"": [
                    ""Permet de questionner un joueur mort permanent."",
                    [
                      ""Coût : 2"",
                      ""Durée : 5 minutes"",
                      ""Type : Animation""
                    ],
                    ""aucun""
                  ],
                  ""title"": ""Ancêtre""
                },
                {
                  ""description"": [
                    ""Ramène en mort-vivant un esclave qui conserve sa production."",
                    [
                      ""Coût : 10"",
                      ""Durée : Permanent"",
                      ""Type : Production""
                    ],
                    ""Doit posséder un esclave mort""
                  ],
                  ""title"": ""Recyclage d'esclave""
                },
                {
                  ""description"": [
                    ""Transforme un cadavre en spectre capable de passer au travers des murs, d'entendre et de parler, mais qui n'est pas invisible et qui ne peut pas faire autre chose. "",
                    [
                      ""Coût : 5"",
                      ""Durée : 15 minutes"",
                      ""Type : Animation""
                    ],
                    ""Doit utiliser un corp mort (achevé).""
                  ],
                  ""title"": ""Spectre""
                },
                {
                  ""description"": [
                    ""Comme un spectre, mais complètement invisible. De plus le fantôme ne peut pas mourir permanent de cette façon."",
                    [
                      ""Coût : 8"",
                      ""Durée : 15 minutes"",
                      ""Type : Animation""
                    ],
                    ""Doit utiliser un corp mort (achevé).""
                  ],
                  ""title"": ""Esprit Fantôme""
                },
                {
                  ""description"": [
                    ""Permet à un animateur de relever tous les personnages morts ou assomés en Momie."",
                    [
                      ""Coût : ----"",
                      ""Durée : Jusqu'à la mort"",
                      ""Type : Animation""
                    ],
                    ""Doit utiliser un corp mort (achevé). Le mort est détruit une fois a 0 pv et va directement au cimetière.""
                  ],
                  ""title"": ""Cimetière de liche""
                },
                {
                  ""description"": [
                    ""Permet d'invoquer le Golem d'Ossuaire."",
                    [
                      ""Coût : QUEST"",
                      ""Durée : Jusqu'à la mort"",
                      ""Type : Animation""
                    ],
                    ""Ajoute les victimes à sa structure.""
                  ],
                  ""title"": ""Nécronaute""
                }
              ]
            },
            {
              ""title"": ""Magie Noire"",
              ""section"": [
                {
                  ""description"": [
                    ""Permet de détruire 3 mort-vivants pour créer 10 composantes nécromantiques."",
                    [
                      ""Coût : 5"",
                      ""Durée : Instantanée"",
                      ""Type : Production""
                    ],
                    ""Doit avoir 3 mort-vivants sous son contrôle ou celui des assistants.""
                  ],
                  ""title"": ""Nécro-ingénérie""
                },
                {
                  ""description"": [
                    ""Permet de devenir mort-vivant (doit choisir 3 pouvoirs dans la classe Maître Undead). Permet aussi d'obtenir un phylactère et de ne plus souffrir d'un manque de Karma."",
                    [
                      ""Coût : 120"",
                      ""Durée : Instantanée"",
                      ""Type : Bonus""
                    ],
                    ""Devient mort-vivant""
                  ],
                  ""title"": ""Liche""
                },
                {
                  ""description"": [
                    ""Drain de 3 points de vie et de 3 d'énergie."",
                    [
                      ""Coût : 6"",
                      ""Durée : 1 utilisation"",
                      ""Type : Bonus""
                    ],
                    ""-2 karma au lanceur du sort""
                  ],
                  ""title"": ""Toucher Vampirique""
                },
                {
                  ""description"": [
                    ""Effet: Mort (balle). La cible peut être réssuscitée"",
                    [
                      ""Coût : 8"",
                      ""Durée : 1 utilisation"",
                      ""Type : Effet""
                    ],
                    ""-1 karma au lanceur du sort""
                  ],
                  ""title"": ""Rayon Mortel""
                },
                {
                  ""description"": [
                    ""Les personnages protégés par ce sort qui sont assommés et qui se font achever, explosent en tuant leur assassin."",
                    [
                      ""Coût : (# cibles) X 5"",
                      ""Durée : Jusqu'à effet du sort"",
                      ""Type : Bonus""
                    ],
                    ""Le joueur qui explose et son assassin vont au cimetiere""
                  ],
                  ""title"": ""Mort Piegée""
                },
                {
                  ""description"": [
                    ""Le rituel permet de tracer un cercle de 2 mètres de diamètre. Tous les personnages ayant l'habileté Rituel (Nécromancie) reçoivent alors 5 points d'énergie en Bonus et une sauvegarde contre un effet affectant le Karma."",
                    [
                      ""Coût : 15"",
                      ""Durée : Cercle"",
                      ""Type : Bonus""
                    ],
                    ""Doit rester dans le cercle.""
                  ],
                  ""title"": ""Cercle du mal""
                },
                {
                  ""description"": [
                    ""Permet de renforcer une arme en la rendant mortelle pour les humains. L'arme cause 2 points de dégât aux créatures vivantes."",
                    [
                      ""Coût : 4"",
                      ""Durée : 1 combat"",
                      ""Type : Bonus""
                    ],
                    ""L'arme doit porter un tissu blanc comme un voile.""
                  ],
                  ""title"": ""Lance du mal""
                },
                {
                  ""description"": [
                    ""Permet de poser une question à un mort sans que celui-ci ne puisse mentir ou utiliser Mensonge. 4 composantes pour poser une question supplémentaire (max 5 questions)."",
                    [
                      ""Coût : 4+"",
                      ""Durée : 1 question"",
                      ""Type : Effet""
                    ],
                    ""Doit utiliser un corps mort (achevé)""
                  ],
                  ""title"": ""Communion avec les morts""
                },
                {
                  ""description"": [
                    ""Transforme 5 esclaves en 1 ration."",
                    [
                      ""Coût : 5 (sacrifice)"",
                      ""Durée : Instantanée"",
                      ""Type : Production""
                    ],
                    ""Détruit 5 esclaves""
                  ],
                  ""title"": ""La moulé pour les chien""
                },
                {
                  ""description"": [
                    ""Donne une <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>nécrose</a>."",
                    [
                      ""Coût : 1"",
                      ""Durée : 1 utilisation"",
                      ""Type : Effet""
                    ],
                    ""Toucher""
                  ],
                  ""title"": ""Décomposition""
                },
                {
                  ""description"": [
                    ""Donne 2 <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>nécroses</a>."",
                    [
                      ""Coût : 2"",
                      ""Durée : 1 utilisation"",
                      ""Type : Effet""
                    ],
                    ""Toucher""
                  ],
                  ""title"": ""Putréfaction""
                },
                {
                  ""description"": [
                    ""Donne 3 <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>nécroses</a>."",
                    [
                      ""Coût : 3"",
                      ""Durée : 1 utilisation"",
                      ""Type : Effet""
                    ],
                    ""Toucher, -1 karma au lanceur.""
                  ],
                  ""title"": ""Kyste""
                },
                {
                  ""description"": [
                    ""Détruit une <a target='_self' href='#Mécaniquedebase_Effetsdejeu'>nécrose</a> et regagne 1 point de vie et 1 point d'énergie."",
                    [
                      ""Coût : 1"",
                      ""Durée : 1 utilisation"",
                      ""Type : Effet""
                    ]
                  ],
                  ""title"": ""Décomposeur""
                },
                {
                  ""description"": [
                    ""Dévore un cadavre et récupère 3 points de vie (1 minute)."",
                    [
                      ""Coût : 1"",
                      ""Durée : 1 utilisation"",
                      ""Type : Effet""
                    ],
                    ""La victime doit être morte avant de la dévorer.""
                  ],
                  ""title"": ""Charognard""
                }
              ]
            }
          ]
        },
        {
          ""title"": ""Protection"",
          ""under_level_color"": ""panel-info"",
          ""section"": [
            {
              ""title"": ""Bénédiction"",
              ""section"": [
                {
                  ""description"": [
                    ""Pour le prochain combat les sorts de guérison font 2."",
                    [
                      ""Coût : 4"",
                      ""Durée : 1 combat"",
                      ""Type : Bonus""
                    ]
                  ],
                  ""title"": ""Imposition des mains 1""
                },
                {
                  ""description"": [
                    ""Pour le prochain combat les sorts de guérison font 3."",
                    [
                      ""Coût : 10"",
                      ""Durée : 1 combat"",
                      ""Type : Bonus""
                    ]
                  ],
                  ""title"": ""Imposition des mains 2""
                },
                {
                  ""description"": [
                    ""Pour le prochain combat les sorts de guérison font 4."",
                    [
                      ""Coût : 20"",
                      ""Durée : 1 combat"",
                      ""Type : Bonus""
                    ]
                  ],
                  ""title"": ""Imposition des mains 3""
                },
                {
                  ""description"": [
                    ""Donne la technique Sorcellerie: Rayon de vie 2 point de vie pour la durée du rituel."",
                    [
                      ""Coût : 3"",
                      ""Durée : 1 combat"",
                      ""Type : Bonus""
                    ],
                    ""Doit toucher avec une balle""
                  ],
                  ""title"": ""Rayon de vie 1""
                },
                {
                  ""description"": [
                    ""Donne la technique Sorcellerie: Rayon de vie 3 points de vie pour la durée du rituel."",
                    [
                      ""Coût : 7"",
                      ""Durée : 1 combat"",
                      ""Type : Bonus""
                    ],
                    ""Doit toucher avec une balle""
                  ],
                  ""title"": ""Rayon de vie 2""
                },
                {
                  ""description"": [
                    ""Donne la technique Sorcellerie: Rayon de vie 4 points de vie pour la durée du rituel."",
                    [
                      ""Coût : 15"",
                      ""Durée : 1 combat"",
                      ""Type : Bonus""
                    ],
                    ""Doit toucher avec une balle""
                  ],
                  ""title"": ""Rayon de vie 3""
                },
                {
                  ""description"": [
                    ""Permet de retirer tous les effets de jeu sur une cible."",
                    [
                      ""Coût : 3"",
                      ""Durée : 1 utilisation"",
                      ""Type : Heal""
                    ],
                    ""Toucher""
                  ],
                  ""title"": ""Restauration""
                },
                {
                  ""description"": [
                    ""Permet de récupérer 1 Karma après le rituel. 1 composante / participant."",
                    [
                      ""Coût : 1+"",
                      ""Durée : Instantanée"",
                      ""Type : Bonus""
                    ],
                    ""Minimum 15 minutes. Minimum 6 personnes""
                  ],
                  ""title"": ""Cérémonie""
                },
                {
                  ""description"": [
                    ""Permet de récupérer 3 Karma après le rituel. 3 composantes / participant."",
                    [
                      ""Coût : 3+"",
                      ""Durée : Instantanée"",
                      ""Type : Bonus""
                    ],
                    ""Minimum 15 minutes. Minimum 6 personnes""
                  ],
                  ""title"": ""Messe""
                },
                {
                  ""description"": [
                    ""Donne une sauvegarde contre l'effet Dominé."",
                    [
                      ""Coût : 3"",
                      ""Durée : 1 utilisation"",
                      ""Type : Bonus""
                    ]
                  ],
                  ""title"": ""Barrière mental""
                },
                {
                  ""description"": [
                    ""Permet d'être immunisé à l'effet Dominé."",
                    [
                      ""Coût : 15"",
                      ""Durée : 1 combat"",
                      ""Type : Bonus""
                    ],
                    ""Doit avoir une pierre collée dans le front.""
                  ],
                  ""title"": ""Protection Mental""
                }
              ]
            },
            {
              ""title"": ""Barrière"",
              ""section"": [
                {
                  ""description"": [
                    ""Permet de faire prisonnier, un strône, un squelette, ou une créature végétale."",
                    [
                      ""Coût : 8"",
                      ""Durée : cercle"",
                      ""Type : Paralyse""
                    ],
                    ""Le cercle doit rester intact.""
                  ],
                  ""title"": ""Cercle de confinement 1""
                },
                {
                  ""description"": [
                    ""Permet de faire prisonnier, un gardien, un dry-arbre, ou une goule."",
                    [
                      ""Coût : 16"",
                      ""Durée : cercle"",
                      ""Type : Paralyse""
                    ],
                    ""Le cercle doit rester intact.""
                  ],
                  ""title"": ""Cercle de confinement 2""
                },
                {
                  ""description"": [
                    ""Permet de faire prisonnier, un demon, un illithide, ou une liche."",
                    [
                      ""Coût : 32"",
                      ""Durée : cercle"",
                      ""Type : Paralyse""
                    ],
                    ""Le cercle doit rester intact.""
                  ],
                  ""title"": ""Cercle de confinement 3""
                },
                {
                  ""description"": [
                    ""Permet de faire prisonnier n'importe quoi."",
                    [
                      ""Coût : 64"",
                      ""Durée : cercle"",
                      ""Type : Paralyse""
                    ],
                    ""Le cercle doit rester intact.""
                  ],
                  ""title"": ""Cercle de confinement 4""
                },
                {
                  ""description"": [
                    ""Cercle de 2 mètres où tous les sorts de soins voient leurs Effets doubler."",
                    [
                      ""Coût : 5"",
                      ""Durée : cercle 5 minutes"",
                      ""Type : Bonus""
                    ],
                    ""Le cercle doit rester intact.""
                  ],
                  ""title"": ""Cercle de vie""
                },
                {
                  ""description"": [
                    ""Permet de créer une zone où la mort ne peut être réversible. Le cercle est aussi grand que la corde noire utilisée lors du rituel."",
                    [
                      ""Coût : 12"",
                      ""Durée : cercle 1 combat"",
                      ""Type : Effet""
                    ],
                    ""Le cercle doit rester intact.""
                  ],
                  ""title"": ""Cercle de mort""
                },
                {
                  ""description"": [
                    ""Crée une zone personnelle paralysant la cible, mais la protégeant des 10 prochaines touches. La personne protégée doit compter les touches reçu à voix haute. La cible peut parler, mais ni ses bras, ni ses jambe ne peuvent bouger."",
                    [
                      ""Coût : 2"",
                      ""Durée : 1 utilisation"",
                      ""Type : Effet""
                    ]
                  ],
                  ""title"": ""Cercle de protection personnel""
                },
                {
                  ""description"": [
                    ""Crée une zone personnelle paralysant la cible, mais la protégeant des 10 prochaines touches. La personne protégée doit compter les touches reçues à voix haute. La cible peut parler, mais ni ses bras, ni ses jambes ne peuvent bouger. Chaque personne supplémentaire coûte 2 composantes au moment de préparer le rituel. (Max 5)."",
                    [
                      ""Coût : 3+"",
                      ""Durée : 1 utilisation"",
                      ""Type : Effet""
                    ]
                  ],
                  ""title"": ""Cercle de protection personnel, de groupe""
                },
                {
                  ""description"": [
                    ""Permet de créer une zone de 3 mètres de diamètre où toutes les choses invisibles ou immatérielles sont dévoilées."",
                    [
                      ""Coût : 6"",
                      ""Durée : 1 utilisation"",
                      ""Type : Effet""
                    ]
                  ],
                  ""title"": ""Cercle de dévoilement""
                }
              ]
            }
          ]
        }
      ]
    },
    {
      ""title"": ""Techniques de maître"",
      ""description"": [
        ""Les techniques de maître sont des techniques qui peuvent être choisi qu'après avoir reçu une formation en-jeu avec un PNJ. Un personnage peut avoir dix techniques de maître sur sa fiche de personnage en plus des espaces offertes par les habiletés complètes (5 talents).""
      ],
      ""section"": [
        {
          ""title"": ""Discipline commune"",
          ""description"": [
            ""On peut choisir Endurance et Énergie deux autre fois supplémentaire.""
          ],
          ""section"": [
            {
              ""title"": ""Endurance [l]"",
              ""description"": [
                [
                  ""+1 point de vie maximum"",
                  ""+1 point de vie maximum""
                ]
              ]
            },
            {
              ""title"": ""Énergie [l]"",
              ""description"": [
                [
                  ""+2 points d’énergie maximum"",
                  ""+2 points d’énergie maximum""
                ]
              ]
            }
          ]
        },
        {
          ""title"": ""Discipline combattante"",
          ""section"": [
            {
              ""title"": ""Discipline [c]"",
              ""description"": [
                [
                  ""Lévitation [passif] immunisé à foudroyé"",
                  ""Formation [Dire «formation»] Entre 3 et 6 joueurs prennent position dans une formation. Tant qu’ils tiennent cette formation, ils ont 1 point de vie maximum supplémentaires"",
                  ""Survie [passif] génère une ration par jeu. Est considéré comme ayant suture."",
                  ""Entretien [sauvegarde] cassé.""
                ]
              ]
            },
            {
              ""title"": ""Karma [l]"",
              ""description"": [
                [
                  ""Bénédiction [passif] +3 karma"",
                  ""Phoenix [-5 karma] le joueur revient à la vie avec toute son énergie et tous ses points de vie"",
                  ""Sacrifice [passif] peut échanger 1 point de karma contre 1 point d’énergie"",
                  ""Sanguinaire [passif] Quand le personnage perd du karma, il est guérit d’un point de vie""
                ]
              ]
            },
            {
              ""title"": ""Offense [c]"",
              ""description"": [
                [
                  ""Décapitation [touche au plexus et touche au dos] mort"",
                  ""Brise-Bouclier [sur une charge de 3 pas] bouclier touché est cassé"",
                  ""Casse-Lame [3 touches consécutives sur l’arme] arme touchée est cassée"",
                  ""Titan [passif] Arme à deux mains inflige 2 de dégât (sauf les lances)""
                ]
              ]
            },
            {
              ""title"": ""Défense [c]"",
              ""description"": [
                [
                  ""Robuste [passif] +1 point de vie"",
                  ""Volonté de fer [sauvegarde] domination"",
                  ""Estomac d’acier [sauvegarde] poison et maladies transmises par la salive"",
                  ""Santé de fer [sauvegarde] maladies transmises par l’air, le sang ou la famine""
                ]
              ]
            }
          ]
        },
        {
          ""title"": ""Discipline sournoise"",
          ""section"": [
            {
              ""title"": ""Alchimie [l]"",
              ""description"": [
                [
                  ""Alchimiste prolifique [passif] +3 blocs alchimiques"",
                  ""Alchimiste versatile [passif] peut utiliser un bloc d’herboristerie comme un bloc d’alchimie"",
                  ""Suicide [passif] à tout moment, le joueur peut choisir d’être mort"",
                  ""Distillerie [production] potions""
                ]
              ]
            },
            {
              ""title"": ""Embuscade [c]"",
              ""description"": [
                [
                  ""Nocturne [passif] +1 point de vie la nuit"",
                  ""Maître des pièges [sauvegarde] pièges et toiles"",
                  ""Commotion [sur une personne assommée] oublie les 5 dernières minutes"",
                  ""Déguisement [passif] permet d’avoir un autre costume et d’affirmer être un autre personnage""
                ]
              ]
            },
            {
              ""title"": ""Fourberie [c]"",
              ""description"": [
                [
                  ""Main de fer [sur une poignée de main] démembré"",
                  ""Égorgement [couteau passé sous la gorge] mort  <span class='label label-danger'><span class='glyphicon glyphicon-remove-sign'></span> Bloqué par l’administration</span>"",
                  ""Étouffement [dague au torse] muet"",
                  ""Feinte [sauvegarde] touche (ne fonctionne que sur les attaques normales, ne bloquent pas les techniques, ni les rituels)""
                ]
              ]
            },
            {
              ""title"": ""Travail de précision [c]"",
              ""description"": [
                [
                  ""Chanceux [passif] génère 6 blocs au choix par jeu"",
                  ""Escroc [passif] génère 50 piécettes par jeu"",
                  ""Orfèvre [production] joyau"",
                  ""Triche [instantané] permet d’avoir une chance additionnelle dans un jeu de hasard""
                ]
              ]
            }
          ]
        },
        {
          ""title"": ""Discipline magique"",
          ""section"": [
            {
              ""title"": ""Artisanat Arcane [c]"",
              ""description"": [
                [
                  ""Chimiste prolifique [passif] +3 blocs de production de potions"",
                  ""Chimiste versatile [passif] peut utiliser les blocs d’enchantement pour faire des potions"",
                  ""Enchanteur prolifique [passif] +3 blocs de production d’enchantement"",
                  ""Enchanteur versatile [passif] peut utiliser les blocs de potion pour enchanter""
                ]
              ]
            },
            {
              ""title"": ""Rituel [l]"",
              ""description"": [
                [
                  ""Versatilité I [passif] donne accès à une sous-écoles d’une école de magie différente de la spécialité du joueur. Il doit utiliser des composantes de cette école de magie pour invoquer les rituels."",
                  ""Versatilité II [passif] idem"",
                  ""Versatilité III [passif] idem"",
                  ""Maître des rituels [passif] +5 composantes par jeu""
                ]
              ]
            },
            {
              ""title"": ""Sorcellerie [c]"",
              ""description"": [
                [
                  ""Télékinésie [balle] la cible recule de 10 pas"",
                  ""Tonnerre [balle] 2 de dégât, foudroyé"",
                  ""Sorcier débrouillard[passif] peut utiliser un bloc de potion pour lancer un sort de sorcellerie"",
                  ""Désintégration [balle à un membre] démembré""
                ]
              ]
            },
            {
              ""title"": ""Thaumaturgie [c]"",
              ""description"": [
                [
                  ""Réincarnation [touché] ramène un mort à la vie avec 3 points de vie et 0 énergie"",
                  ""Guérison suprême [touché] guérit 2 points de vie"",
                  ""Guérisseur débrouillard [passif] peut utiliser un bloc d’enchantement pour lancer un sort de thaumaturgie"",
                  ""Restauration [touché] régénère les 4 membres""
                ]
              ]
            }
          ]
        },
        {
          ""title"": ""Discipline professionnelle"",
          ""section"": [
            {
              ""title"": ""Baratin [c]"",
              ""description"": [
                [
                  ""Alcoolique [passif] une consommation redonne un point de vie"",
                  ""Triche [instantané] permet d’avoir une chance additionnelle dans un jeu de hasard"",
                  ""Rumeurs [passif] le joueur obtiens quelques informations sur 3 scènes du jeu suivant. Il obtient notamment l’heure approximative, les factions impliquées, et une idée de l’évènement principal"",
                  ""Éloquence [suite à un discours] Les joueurs défendant la même cause que l’initiateur reçoivent +1 énergie jusqu’à ce que la cause ait été défendue une fois""
                ]
              ]
            },
            {
              ""title"": ""Marchandage [l]"",
              ""description"": [
                [
                  ""Marchand prolifique [passif] +3 bloc au choix par jeu"",
                  ""Échange [passif] le marchand peut échanger n’importe quel deux blocs ou composantes pour un autre type de bloc ou une composante magique"",
                  ""Contrebande [passif] chaque jeu, le joueur peut participé à une enchère avant le jeu avec les autres escrocs pour des objets prédéfinies"",
                  ""Caravane [passif] génère 100 pièces par jeu"",
                  ""Noblesse [passif] génère 50 pièces par jeu""
                ]
              ]
            },
            {
              ""title"": ""Médecine [c]"",
              ""description"": [
                [
                  ""Techniques médicales [passif] permet d’apprendre les techniques de médecine avancées. Chacun doit être apprise en jeu lors d’un séminaire donné par un acteur."",
                  [
                    ""Diagnostic [Stravinsky] Permet à un joueur ayant l’habileté médecine de faire un diagnostique complet d’un patient en passant 15 minutes avec lui. Après la session, le joueur doit révéler au médecin l’ensemble des effets qui pèsent sur lui, incluant tous les effets passifs qui lui sont conférés par des objets ou des techniques. Si le joueur est ignorant d’une condition pesant sur lui, le docteur considère qu’il ne l’a simplement pas découverte. Un diagnostique ne peut pas être perpétrer sur une personne contre son gré."",
                    ""Psychanalyse [Stravinsky] Un patient ayant fait ses consultations régulières pour 3 jeux consécutifs est assez près de son médecin pour recevoir ses conseils psychologiques. Chaque jeu, le médecin peut poser une question à son patient qui doit lui répondre la vérité. Le médecin infère cette information des discussions et observations sur son patient, l’habileté mensonge n’est donc pas efficace."",
                    ""Autopsie [Stravinsky] permet de déterminer la cause de la mort d’un joueur""
                  ],
                  ""Techniques chirurgicales [passif] permet d’apprendre les techniques de chirurgie avancées. Chacune doit être apprise en jeu lors d’un séminaire donné par un acteur."",
                  [
                    ""Amputation [Von Brett] le médecin peut retirer un membre d’un joueur mort ou assommé de façon propre et professionnelle. Si le docteur retire un bras, la cible ne peut plus se servir de ce bras avant d’être guérit magiquement (guérison est efficace)"",
                    ""Ablation [Von Brett] permet de retirer un organe à un joueur mort ou assommé. Un joueur assommé meurt à la fin de la procédure. Quand le joueur revient à la vie, il a une pénalité d’un d’énergie jusqu’à ce qu’il prend un remède."",
                    ""Transfusion [Von Brett] permet de faire une transfusion sanguine entre deux joueurs. Les potions, poisons et maladies qui affectent le joueur donateur sont transmises au joueur receveur. Toute potion ou remède administré 5 minutes avant la transfusion prend effet dans le corps receveur aussi.""
                  ],
                  ""Recherche pharmacologique [passif] le joueur apprend les recettes avancées de médicaments"",
                  ""Dextérité [passif] réduit le temps d’opération et suture de 10 secondes""
                ]
              ]
            },
            {
              ""title"": ""Métier [c]"",
              ""description"": [
                [
                  ""Artisan versatile [passif] permet d’utiliser un bloc de forge comme un bloc d’artisanat, et inversement"",
                  ""Forgeron prolifique [passif] +3 blocs de forge"",
                  ""Artisan prolifique [passif] +3 blocs artisanaux"",
                  ""Herboriste prolifique [passif] +3 blocs d’herboristerie""
                ]
              ]
            }
          ]
        }
      ]
    },
    {
      ""title"": ""Fortification"",
      ""title_html"": ""Fortification <span class='label label-info'><span class='glyphicon glyphicon-star'></span> Nouveau</span>"",
      ""description"": [
        ""La résistance d’une porte, que ce soit une porte de forteresse ou de taverne, dépend du nombre de bloc de production (bp) artisanat : Fortification."",
        ""1 porte de Forteresse : 50 bp artisanat : Fortification maximum"",
        ""1 porte de bâtiment : 10 bp artisanat : Fortification maximum,"",
        ""1 bp artisanat : Fortification = 1 point de vie de fortification."",
        ""1 bp artisanat : Fortification Enchantée = 2 points de vie de fortification."",
        ""1 bp forgeron : Engin de siège = 1 projectile d’arme de siège ou 1 coup de bélier."",
        ""* Un projectile d’arme de siège cause 1 point de dégât de fortification et fait le sortilège ''mort'' sur un personnage, sans possibilité de sauvegarde. Le projectile doit absolument avoir été tiré par un engin de siège décorum. Un coup de bélier cause 1 point de dégât de fortification."",
        ""1 bp forgeron : Engin de siège enchanté = 1 projectile enchanté d’arme de siège ou 1 coup de bélier enchanté**."",
        ""** Un projectile d’arme de siège enchanté cause 2 points de dégât de fortification et fait le sortilège ''mort'' sur un personnage, sans possibilité de sauvegarde. Le projectile doit absolument avoir été tiré par un engin de siège décorum. Un coup de bélier enchanté cause 2 points de dégât de fortification.**"",
        ""Engin de siège en bluam : Permet de désenchanter une fortification. Une seule utilisation."",
        ""Engin de siège en sanglite : Permet de causer 50 points de dégât de fortification à une fortification. Une seule utilisation."",
        ""Engin de siège en malachite : Une fortification détruite par un engin de siège en malachite ne peut pas être reconstruite pour la durée d'une lune entière."",
        ""Rituels Inédits : Ces rituels sont uniques et disponibles uniquement en jeu. Ils affectent toutes les fortifications. Exemples: Mur de pierre, Mur de fer, Mur de force, Séisme, Trou Noir, Forteresse Immédiate Balmonts, Mur des enfer, Mur d’ombre. Forteresse de Bluam, Forteresse Végétale, ect."",
        ""Tous les rituels de création affectant une fortification peuvent prendre l’apparence d’un Symbole Magique. Celui-ci peut alors être activé par n’importe qui ayant participé au rituel. Ce Symbole doit mesurer minimum 30 cm.""
      ]
    },
    {
      ""title"": ""Distribution de points de mérite"",
      ""description"": ""Il est possible d'obtenir des points de mérite selon son implication sur l'activité de Traître-Lame. Dans cette section, on vous montre ce qu'on peut obtenir en échange de point(s) de mérite."",
      ""section"": [
        {
          ""title"": ""Coût de 1 point de mérite"",
          ""section"": [
            {
              ""title"": ""Expérience"",
              ""description"": ""Donne 1 point d'expérience sur la fiche du personnage actif.""
            },
            {
              ""title"": ""Karma"",
              ""description"": ""Donne 10 point de Karma temporaire pour le jeu. (max 1/jeu).""
            },
            {
              ""title"": ""Énergie Star"",
              ""description"": ""Donne 4 points d'énergie temporaire pour le jeu. (max 1/jeu).""
            },
            {
              ""title"": ""Money Bag"",
              ""description"": ""Donne un bonus unique de 50 pièces d'or au début du jeu.""
            },
            {
              ""title"": ""Ritualiste"",
              ""description"": ""Donne un bonus unique de 20 composantes magiques au début du jeu.""
            },
            {
              ""title"": ""Artisan"",
              ""description"": ""Donne un bonus unique de 30 blocs de production au choix au début du jeu.""
            },
            {
              ""title"": ""Métal Rare"",
              ""description"": ""Donne un bonus unique d'un lingot rare au choix au début du jeu.""
            }
          ]
        },
        {
          ""title"": ""Coût de 3 points de mérite"",
          ""section"": [
            {
              ""title"": ""Marché Public"",
              ""description"": ""Donne accès a un commerce de Malédastarone gratuitement.""
            },
            {
              ""title"": ""Marché Tribale"",
              ""description"": ""Donne accès a un commerce de la Sarsonne gratuitement.""
            },
            {
              ""title"": ""Money Chest"",
              ""description"": ""Donne un bonus unique de 200 pièces d'or au début du jeu.""
            },
            {
              ""title"": ""Cercle de Mage"",
              ""description"": ""Donne un bonus unique de 50 composantes magiques au début du jeu.""
            },
            {
              ""title"": ""Atelier en série"",
              ""description"": ""Donne un bonus unique de 100 blocs de production au choix au début du jeu.""
            }
          ]
        },
        {
          ""title"": ""Coût de 5 points de mérite"",
          ""section"": [
            {
              ""title"": ""Marché Noir"",
              ""description"": ""Donne accès a un commerce Illicite gratuitement.""
            },
            {
              ""title"": ""Appuis: Commercial"",
              ""description"": ""Donne un bonus de 3 Appuis: Commercial au début du jeu. (Faction, Sous-Faction ou Personnelle)""
            },
            {
              ""title"": ""Appuis: Militaire"",
              ""description"": ""Donne un bonus de 3 Appuis: Militaire au début du jeu. (Faction, Sous-Faction ou Personnelle)""
            },
            {
              ""title"": ""Appuis: Info"",
              ""description"": ""Donne un bonus de 3 Appuis: Information au début du jeu. (Faction, Sous-Faction ou Personnelle)""
            },
            {
              ""title"": ""Appuis: Politique"",
              ""description"": ""Donne un bonus de 3 Appuis: Politique au début du jeu. (Faction, Sous-Faction ou Personnelle)""
            },
            {
              ""title"": ""Appuis: Criminel"",
              ""description"": ""Donne un bonus de 3 Appuis: Criminel au début du jeu. (Faction, Sous-Faction ou Personnelle)""
            }
          ]
        },
        {
          ""title"": ""Coût de 10 points de mérite"",
          ""section"": [
            {
              ""title"": ""Résurection"",
              ""description"": ""Permet de ramener un personnage mort permanent à la vie sans même avoir une miette du défunt.""
            },
            {
              ""title"": ""Coffre du Roi"",
              ""description"": ""Donne un bonus de 500 pièces d'or, 5 joyaux et une couronne.""
            },
            {
              ""title"": ""Nexus de magie"",
              ""description"": ""Donne un bonus unique de 150 composantes magiques et une sphère de magie.""
            },
            {
              ""title"": ""Atelier du Père Noël"",
              ""description"": ""Donne un bonus de 200 blocs de production au choix et 3 lingots rares aux choix.""
            }
          ]
        }
      ]
    }
  ]
}
";
        }
    }
}
