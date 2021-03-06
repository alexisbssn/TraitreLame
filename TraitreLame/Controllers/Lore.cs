﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraitreLame.Controllers
{
    public static class Lore
    {
        public static string GetLoreSample()
        {
            return @"
{
  ""lore"": [
    {
      ""title"": ""Univers de jeu"",
      ""description"": [],
      ""section"": []
    }
  ]
}
";
        }
        public static string GetLore()
        {
            return @"
{
  ""lore"": [
    {
      ""title"": ""Univers de jeu"",
      ""description"": [
        ""Les joueurs de Traitre-Lame sont la région nordique de la Sarsonne. Il s’agit d’une péninsule reculée du continent où aucune faction ne domine réellement. On y trouve de bons lots de brigands, de créatures et d’organisations douteuses. L’histoire de la région se compte au gré des guerres, des vagues d’exilés cherchant une nouvelle vie ou purgeant une sentence et d’innombrables phénomènes ésotériques ayant rendu la région célèbre. Au loin dans le monde civilisé, on parle de la Sarsonne comme une terre maudite et sauvage."",
        ""Le terrain de l’Atelier du Loisir représente le village de Vallam et les diverses installations coloniales autour de ce carrefour important de la Sarsonne.  Vallam y représente un point central. C’est un lieu où les frontières des différentes factions de la Sarsonne se rencontrent.  Il s'agit donc d’une terre de diplomatie, de traîtrise et de constants conflits."",
        ""Les joueurs incarnent des habitants de la Sarsonne provenant de divers passés. Afin de définir le leur, les joueurs doivent déterminer leur race, et leur origine. La race ne donne pas un avantage de jeu direct, mais fournit un élément pour définir le personnage. Il existe certaines opportunités disponibles seulement aux membres de certaines races. L’origine du personnage est la faction dans lequel le joueur commence son premier jeu. Il existe 5 factions jouables :"",
        [
          ""Le royaume de Canavim"",
          ""L'empire de Vanicant"",
          ""La tribu de Sarsar"",
          ""Le village de Vallam"",
          ""Les Balmonts""
        ],
        ""Les joueurs ont le choix une fois en jeu de choisir leur allégeance selon leur bon gré. Il existe aussi des factions à découvrir en jeu dans lesquels les joueurs peuvent s’investir. Le document est divisé en trois parties : les races, les factions de départ et autres factions.""
      ],
      ""section"": [
        {
          ""title"": ""Cartes"",
          ""description"": """",
          ""section"": [
            {
              ""title"": ""La Sarsonne"",
              ""description"": [
                ""Carte du terrain."",
                {
                  ""type"": ""image"",
                  ""src"": ""static/resources/media/carte_de_demi_terrain.jpg""
                }
              ]
            },
            {
              ""title"": ""Carte du monde"",
              ""description"": [
                ""Map du monde."",
                {
                  ""type"": ""image"",
                  ""src"": ""static/resources/media/carte_du_monde.jpg""
                }
              ]
            }
          ]
        },
        {
          ""title"": ""Races"",
          ""section"": [
            {
              ""title"": ""Humain"",
              ""description"": ""Race la plus commune sur le continent. Dans la majorité des États, les humains tiennent toutes les charges de pouvoir. On les retrouve dans toutes les conditions, malgré tout.""
            },
            {
              ""title"": ""Wartul"",
              ""description"": ""Originaires de la forêt Waldur à l’est du continent, ces humanoïdes à la peau verte ont une intelligence et des aptitudes comparables aux humains. Pendant la majorité de leur histoire, les Wartuls ont été isolés dans leur forêt. Leur premier contact avec l’humanité fut leur conquête par l’empire de Vanicant. Pendant plusieurs siècles, ils ont appris à évoluer dans l’empire, restant majoritairement confinés à leur petit territoire. Grâce aux différents tumultes politiques, la forêt Waldur est redevenue un royaume Wartul autonome. Depuis, nombre de ses citoyens ont ouvert leurs horizons et partent à travers le monde.""
            },
            {
              ""title"": ""Meldorsan"",
              ""description"": ""Ces humanoïdes à la peau pâle striée de veines mauves et bleues saillantes se sont adaptés à un environnement nordique. Les souches de toutes les familles Meldorsanes remontent aux différentes péninsules nordiques qui ont tranquillement migré leur population croissante au sud. Tant dans l’empire de Vanciant que dans le royaume de Canavim, on retrouve des familles nobles Meldorsanes.""
            }
          ]
        },
        {
          ""title"": ""Factions de départ"",
          ""section"": [
            {
              ""title"": ""Le Royaume de Canavim"",
              ""description"": [
                ""Il y a un peu plus d’un siècle et demi, le grand empire de Vanicant se scindait en deux sous le choc d’une rébellion des seigneurs de l’ouest. C’était la naissance du Royaume de Canavim, sous la gouvernance du roi Herbert Aquinas 1er et de ses six seigneurs de guerre, maintenant Archiducs. Sous la dynastie Aquinas, trois rois se sont succédé, tous nommé Herbert en souvenir du mythique premier roi de Canavim. Les règnes des rois Herbert 1er, 2e et 3e furent marqués par une abondance manifeste, de nombreux succès militaires et une grande harmonie dans le royaume. Cette période glorieuse prit fin avec la mort suspecte et soudaine du roi Herbert III, alors que son fils et héritier, Herbert IV, n’était âgé que de 8 ans. Une terrible guerre civile éclata, au terme de laquelle le pouvoir du roi fut secrètement divisé entre les 6 archiducs des grandes provinces de Canavim."",
                ""C’est dans ce contexte de division que l’Archiduc Casséris Ventour, une ancienne liche des territoires nordiques, choisit d’envoyer un corps expéditionnaire en Sarsonne pour fonder un Marquisat fidèle au royaume de Canavim. La conquête de la Sarsonne se buta à la résilience des locaux et à la compétition de Vanciant. Si le Marquisat fut en définitive établi, la Marquise disparut dans de mystérieuses circonstances la même année. Devant les nombreuses difficultés de la colonisation de la Sarsonne, les forces de Canavim se sont éventuellement tournées vers le choix des alliances et de la coopération locale. Le drapeau de Canavim est rapidement devenu un symbole d’espoir en Sarsonne, les forces expéditionnaires fondant l’ordre des chevaliers du peuple pour protéger les localités de Sarsonne des nombreux périls du nord."",
                ""Les joueurs peuvent incarner un soldat membre des forces coloniales de Canavim, un colon venu du royaume ou un sympathisant local. Un groupe de joueurs peut désigner un noble parmi ses rangs, à discuter avec l’organisation."",
                [
                  ""L'étendard de Canavim est une tête de bouc de côté sur fond bleu et blanc;"",
                  ""La langue nobiliaire de Canavim est l’anglais, mais la langue populaire est le français;"",
                  ""Le site principal de la faction est la forteresse à l’entrée du terrain;"",
                  ""La religion officielle de Canavim est le Maratisme, une religion qui place les dieux comme des modèles que doivent imiter les êtres humains.""
                ],
                {
                  ""type"": ""image"",
                  ""src"": ""static/resources/media/Canavim.jpg""
                }
              ]
            },
            {
              ""title"": ""L'empire de Vanicant"",
              ""description"": [
                ""Maintenant situé principalement à l’est du continent, l’empire de Vanicant a déjà couvert presque toutes les terres continentales. C’est un empire presque millénaire, qui a su prospérer à travers les âges, traverser les crises et se renouveler pour assurer sa survie. Au coeur du fonctionnement de l’empire se trouve un rigide système de castes. Au bas de ce système se trouvent les esclaves. La majorité de la population se retrouve dans la caste des communs, qui occupent les emplois les plus humbles, mais souvent les plus nécessaires. Au-dessus, on retrouve les experts, qui occupent les professions libérales et les postes de basse administration. Finalement, on retrouve une noblesse dominée par 5 familles régnantes : les Borgata du nord-ouest, les Anturis au centre et au nord, Les Zazanov à l’Ouest, les Belchir au Sud et les Cirado à l’est. Ces familles ont longtemps dominé l’empire à travers le conseil des Patriarches, soutenu par le sénat impérial."",
                ""Quand Canavim envoya une force pour annexer la Sarsonne au nord, Vanciant mobilisa les troupes d’élite de la garde écarlate pour bloquer l’expansion de son voisin rival. Or la colonie de Vanicant au nord devait prendre une tout autre vocation avec le temps. De cette position reculée, un mouvement de révolution cherchant à endiguer la corruption des patriarches en restaurant le pouvoir de l’impératrice est né. Avec l’aide de nombreuses organisations, la force expéditionnaire de Vanicant en Sarsonne devint un repère sécuritaire pour les personnages clefs de la révolution. Alors que la guerre fait encore rage, les familles Zazanov, Belchir et Cirado se sont toutes soumises au nouveau pouvoir impérial. Les familles Borgata et Anturis ont formé leurs propres États, refusant d’abandonner leur pouvoir. La révolution a aussi séparé de Vanciant la forêt Waldur, libérant le peuple Wartul de plusieurs siècles de domination vanicante."",
                ""Les joueurs peuvent incarner des membres des forces coloniales de Vanicant, des colons de l’empire ou des sympathisants locaux. Un groupe de joueurs peut désigner un noble parmi ses membres, à discuter avec l’organisation."",
                [
                  ""L’étendard de Vanciant est la couronne impériale en noir sur fond rouge;"",
                  ""Bien que la majorité de Vanicant parle le français, les terres désertiques du sud sont largement occupées par la population Al Aquine, parlant arabe;"",
                  ""Le site principal de la faction est la forteresse de croûte cachée en forêt;"",
                  ""La religion officielle de Vanicant est le Sravénisme, une religion qui place le Cosmos comme une grande force qui régit tous les aspects de la vie.""
                ],
                {
                  ""type"": ""image"",
                  ""src"": ""static/resources/media/Vanicant.jpg""
                }
              ]
            },
            {
              ""title"": ""La tribu Sarsar"",
              ""description"": [
                ""La Sarsonne a été pour la majorité de son histoire une péninsule boisée et froide, où très peu d’individus osaient s’installer. La tribu Sarsar est le seul peuple que l’on peut dire natif de la région. Ils ont toujours conservé une existence tribale et chamanique axée sur la vénération des ancêtres, la guerre et le respect de la nature. La grande capitale d’Etar’Tiak fut par contre le siège de nombreux gouverneurs coloniaux ayant capturé la Sarsonne à travers les âges. Le plus notable de ces envahisseurs, la tribu Strône de la péninsule voisine, fut évincé dans une violente révolution il y a plus d’un siècle. La tribu coexiste depuis avec les nombreuses forces de Sarsonne, se jurant de reprendre le contrôle total des terres un jour. La tribu est dirigée par un vaste conseil présidé par le Guide suprême de la tribu. Siègent sur ce conseil les vénérables patriarches, reconnus pour leur sagesse, ainsi que les guides et grands guides Sarsar qui organisent les clans de la tribu partout en Sarsonne."",
                ""La région de la Grande Forêt, celle qui borde le village de Vallam, est occupée par plusieurs clans Sarsars. Le plus célèbre est certainement le clan Ish, qui a combattu avec détermination les envahisseurs coloniaux. Ce clan a construit avec les années une proximité entre les druides et la tribu. Cela a permis d’utiliser les forces déchaînées de la nature dans leur lutte contre les empires coloniaux. On y retrouve aussi le clan Smith, composé de colons des empires ayant rejoint la tribu volontairement. Plus terre à terre, se concentrant sur la géopolitique et le commerce, ce clan compte vaincre les empires avec leurs propres armes. Nombre d’autres clans ont marché aux côtés de ces deux, et d’autres viendront certainement peupler les terres de la Grande Forêt."",
                ""Un joueur Sarsar peut incarner un membre d’un clan existant ou fonder son propre clan s’il vient avec un groupe. Un clan peut désigner son propre chef et déterminer ses propres traditions."",
                [
                  ""Les Sarsars n’ont pas d’étendard unique. Chaque clan porte ses propres couleurs, et marque son appartenance à la tribu Sarsr par la construction de nombreux totems dévoués à la vie, à la guerre, à la nature, au Cosmos et aux ancêtres;"",
                  ""La tribu Sarsar parle le français;"",
                  ""Les sites principaux de la faction sont le village suspendu et la fermette;"",
                  ""La religion officielle de la tribu Sarsar est le Sravénisme totémique, où l’influence du Cosmos est fractionnée en 5 totems (Ancêtre, vie, nature, Cosmos et guerre) et où le Vide représente les forces obscures.""
                ]
              ]
            },
            {
              ""title"": ""Le village de Vallam"",
              ""description"": [
                ""Pendant la majorité de son histoire, la Sarsonne a servi de terre d’exil pour les deux grands empires. Quand un citoyen était accusé de crimes graves, il pouvait être condamné à une vie recluse au coeur des dangers de la Sarsonne. Cette pratique a créé les nombreux petits villages nordiques de la région, échappant au contrôle des différentes factions. Le village de Vallam occupe une position centrale en Sarsonne. Géographiquement, c’est la croisée des chemins entre les factions du nord, ce qui en fait un lieu de rencontres diplomatiques, de conquêtes et de conflits. Le village est aussi un nid de trafiquants, de bandits et de cultistes uni dans leur détermination à conserver leur autonomie. Le village a historiquement été dirigé par un maire, bien que les mandats soient réputés très courts."",
                ""Depuis l'arrivée des forces coloniales des empires, le village de Vallam a tenté de tirer son épingle du jeu tout en conservant son autonomie. On retrouve des villageois dans presque toutes les manigances, s’alliant aux créatures les plus immondes pour assurer leur survie. Le village est aussi au centre de plusieurs cultes, notamment un culte de la nuit voué au dieu Cesserak (qu’ils prononcent Kesserak pour se distinguer des autres religions). C’est aussi le village qui a accueilli la créature Natueur et fondé la base du culte de shamans noirs, qui visent à étendre l’influence de Natueur sur le continent."",
                ""Un joueur au village peut incarner un natif, un exilé venu rejoindre la localité ou un déserteur d’une des autres factions cherchant la liberté. Un groupe de joueur peut désigner un de ses membres afin d’obtenir un statut particulier (noble déchu ou fils d’un célèbre voleur, par exemple). À discuter avec l’organisation."",
                [
                  ""Le village de Vallam change d’étendard au gré de ses dirigeants;"",
                  ""Toutes les communautés et langues existent au village;"",
                  ""Le site principal du village de Vallam est le village à l’entrée du terrain;"",
                  ""Il y a pratiquement autant de religions que d’individus au village.""
                ]
              ]
            },
            {
              ""title"": ""Les Balmonts"",
              ""description"": [
                ""Il y a de cela de nombreux siècles, la famille Balmont était une puissante famille noble de Vanicant, situé dans la région des Pics de Feu. Dans un grand tremblement de terre suivant de nombreuses éruptions volcaniques, les terres des Balmonts se volatilisèrent d’une journée à l’autre. Tous croyaient la famille disparue à jamais, mais leur malédiction était bien pire. Les Balmonts et leurs forces furent jetés dans les dunes de débris de l’Enfer où ils furent condamnés à combattre inlassablement ses habitants infernaux. Cette situation désespérée construit une faction militariste, paranoïaque et sévèrement endoctrinée dans sa recherche de la pureté. Cette dévotion et cette discipline leur ont permis de ne jamais abandonner la recherche pour une voie de sortie."",
                ""Il y a seulement deux ans, les Balmonts sont parvenus à ouvrir une brèche intermittente en Sarsonne pour permettre aux leurs de reprendre une influence dans le monde matériel. Ils ont fondé une ligue de défense pour unir les citoyens de Sarsonne à leur bannière. Depuis leur retour, les Balmonts ont tissé des liens avec les grands empires sans toutefois perdre leur indépendance. La majorité de leurs efforts tournent encore autour de la purification des nombreuses horreurs de Sarsonne et aux expéditions au-delà de la brèche infernale pour supporter leurs frères toujours en Enfer."",
                ""Les joueurs incarnent des convertis à l’idéologie Balmont. Un groupe de joueur peut nommer un capitaine qui répond pour l’unité. À discuter avec l’organisation."",
                [
                  ""L’étendard Balmont est une croix prolongée pour former un B sur fond blanc;"",
                  ""Les Balmonts parlent français;"",
                  ""Le site principal des Balmonts est la petite forteresse au coeur de la forêt de bouleaux;"",
                  ""Les Balmonts pratiquement le Sravénisme et le Maratisme, mais subordonne la pratique religieuse à la recherche de la pureté.""
                ]
              ]
            }
          ]
        },
        {
          ""title"": ""Autres factions en Sarsonne"",
          ""section"": [
            {
              ""title"": ""La Guilde d'Amunsrat"",
              ""description"": [
                ""Depuis près de 50 ans, cette organisation survie de la traite d’esclaves. Pendant longtemps, l’isolation au nord a permis à la guilde de croître avec un bon réseau stable. Or, à l'arrivée des empires coloniaux en Sarsonne, les choses ont changé. Lors de la première invasion Strône, ils furent largement décimés. Il leur a fallu 4 ans pour rebâtir, juste à temps pour la seconde invasion Strône. Or cette fois, ne voulant pas être de nouveau anéantis, ils ont choisi de supporter l’invasion en assurant la logistique de la guerre du Roi Strône."",
                ""Un nécromancien à l’humour morbide du nom de Slaven a élu domicile près de Vallam pour brasser les affaires de la guilde dans la région. On le retrouve généralement la nuit, loin dans la forêt, dans une forteresse décharnée au-delà du village Sarsar.""
              ]
            },
            {
              ""title"": ""Le Royaume de Figaro"",
              ""description"": [
                ""Il y a une génération, un puissant élémentaliste de Canavim se rendait en Sarsonne pour baigner de feu les forêts nordiques afin de débusquer un groupe de traitres. Dans le chaos de cette époque, un jeune page de Canavim du nom de Valentin Figaro a rassemblé brigands et clans épars de l’est de la Sarsonne pour fonder un royaume sans foi ni loi, sujet à ses caprices. Le groupe a vite développé une expertise en alchimie pour garantir leur survie. Au moment de l’arrivée des forces coloniales en Sarsonne, l’empire de Vanicant a reconnu l’auto proclamée roi en mariant une fille noble du clan Borgata à l’ignoble roi nordique. La lune de miel fut bien courte. Figaro devint un fier défenseur du gouvernement des patriarches. Ses poisons furent au coeur de nombreux assassinats politiques, incluant une tentative ratée sur l’impératrice elle-même. Ses terres sont aujourd’hui envahies par les forces de la Confrérie de Bronze, le roi Valentin Figaro maintenant en exil."",
                ""Afin de lever les fonds nécessaires pour continuer la guerre contre la Confrérie de Bronze, Figaro a envoyé un homme de main surnommé le Colosse. Ce grivois roublard rôde près de Vallam le jour, disparaissant la nuit pour diriger sa compagnie de brigands.""
              ]
            },
            {
              ""title"": ""La Confrérie de Bronze"",
              ""description"": [
                ""La chute du premier régime impérial de Vanicant a donné lieu à nombre de turbulences. Pour la vieille garde, le monde changeait durablement, mais beaucoup voulaient continuer à combattre pour l’ancien ordre. La confrérie de bronze a commencé comme une petite association de notables déchut dans le changement de régime. Le but ultime était de restaurer le pouvoir impérial. L’organisation avait vite muté en un nid de criminels, les idéaux passés jetés au rencart. Un jeune idéaliste du nom de Darko Zazanov a ranimé la flamme impériale du groupe avec l’aide des forces coloniales de l’empire en Sarsonne. À travers nombre d’assassinats politiques, de manipulation et de combat acharné, la Confrérie renouvelée a créé un vent de révolution qui a mené à la récente restauration du pouvoir impérial. En Sarsonne, la confrérie s’est embourbée dans une guerre d’occupation dans le royaume de Figaro."",
                ""Darko Zazanov est toujours en Sarsonne et se présente régulièrement à Vallam pour superviser les opérations de la confrérie près du village. Il passe généralement sous le couvert de la nuit.""
              ]
            },
            {
              ""title"": ""Les pirates d'Angbar d'Allurstriase"",
              ""description"": [
                ""Angbar d’Allurstriase est une légende vivante. C’est un aventurier, sortie de nulle part, qui dans son jeune âge a rallié par son grand charisme nombre de navires. Il s’est enrichi en pillant la marine marchande des empires sur les rives nordiques du continent. De là, il a recruté les plus puissants experts de magie de création pour créer l’unique nexus de création en existence. Au sommet de sa puissance, il a construit une armée de golems pour prendre le contrôle de la Sarsonne. Son armée fut détruite suite à la trahison d’un de ses agents et du meurtre de son maître enchanteur. Ses ambitions de conquête détruite, le pirate s’est rabattu sur le commerce d’objets magiques, et il vie comme un roi au nord de la Sarsonne. Il est présentement au coeur de l’invasion Strône, ses forces luttant pour repousser l’envahisseur."",
                ""Angbar a envoyé un de ses enchanteurs, Cyril de Valprenant, à Vallam pour obtenir le soutien des locaux contre l’invasion Strône. L’enchanteur semble impossible à trouver la nuit.""
              ]
            },
            {
              ""title"": ""Les barbares Strônes"",
              ""description"": [
                ""Natif d’une péninsule à l’ouest de la Sarsonne, il s’agit d’une tribu de pillards et de barbares avec une longue histoire de rivalité avec la Sarsonne. Ils ont jadis occupé le territoire et réduit à l’esclavage la tribu Sarsar. Depuis, les deux peuples sont ennemis. Depuis l'arrivée des empires en Sarsonne, les Strônes ont fait deux invasions massives. La première était dirigée par Muladath Strône, qu’on appelle aujourd’hui le dernier empereur Strône. Il a été défait pendant l’invasion de Vallam et grièvement blessé, annonçant le début d’une pénible retraite pour les barbares nordiques. Leur deuxième invasion est fort récente, et par trois fronts. D’un côté, un nouveau roi Strône mène une attaque par la petite enclave Strône en Sarsonne à travers les terres d’Angbar et de la tribu Sarsar. À partir de Port-Marais, le portail ouvert par les Strônes permet au gros de la force de déferler dans les terres Sarsar. Finalement, un clan particulièrement brutal que l’on appelle le Crâne Sanglant a conquis une lisière de territoire entre les terres Sarsar et de Figaro d’où ils mènent des pillages."",
                ""Le chef du clan du Crâne Sanglant, Morla l’arracheur de tête s’est installé près de Vallam afin de représenter les forces Strônes dans la région. S’il a ses propres objectifs également, il maraude autour du village la nuit, souvent avec quelques-uns de ses pillards.""
              ]
            },
            {
              ""title"": ""Maledastarone"",
              ""description"": [
                ""La Sarsonne est délimitée par un long fleuve qui coupe le continent. Au coeur de ce cours d’eau se trouve la grande cité État de Maledastarone, coeur économique de la Sarsonne. Cette ville neutre accueille tous les visiteurs et distribue tous les types de produits et services. La sécurité dans la ville est assurée par une garde sournoise faisant usage de tunnels infinis creusés sous les bâtiments de la ville. La ville est dirigée par un mystérieux personnage que l’on nomme le Grand Coordonnateur. Ses adjoints sont dénudés de leur identité et portent comme nom un numéro correspondant au nombre d’adjoints engagés avant le candidat. Ces agents gèrent les guildes marchandes et les associations d’artisans de la ville en plus d’en organiser la défense."",
                ""Le réputé collectionneur 73 fait maintenant des visites régulières à Vallam pour flairer les opportunités d’affaires. Une fois par mois, l’adjoint de haut niveau se présente au village pour parler affaires et offrir des contrats.""
              ]
            },
            {
              ""title"": ""Les Druides"",
              ""description"": ""Sur le continent, la mention des druides soulève la peur et la haine. Ces humains à l'apparence animale veulent éliminer la civilisation humaine pour retourner le monde à une existence plus simple. Les druides ont toujours été actifs dans le nord. Près de Vallam, les clans Sarsars ont généralement supporté leur cause. Si les druides ont longtemps terrorisé la région de Vallam, ils sont devenus beaucoup plus discrets depuis l’arrivée de Natueur. La créature a détruit la Racine Mère, une importante source de magie naturelle pour les druides. Depuis cette défaite, les druides ont concentré leurs forces dans la restauration de leur puissance magique et la lutte à Natueur. Les druides sont peu sociables, alors il est très difficile de trouver leurs représentants.""
            }
          ]
        }
      ]
    },
    {
      ""title"": ""Dieux"",
      ""description"": ""Le monde est influencé par plusieurs dieux dans cet univers. La liste des dieux est statique, mais les religions sont multiples, chacune vénérant à sa façon les dieux existants, parfois mettant l'emphase sur l'un plutôt que sur l'autre. Voici la liste des dieux et leur description la plus consensuelle entre les religions."",
      ""section"": [
        {
          ""title"": ""Brokrand"",
          ""description"": ""Dieu de la justice, Brokrand est un dieu qui a gagné en importance avec l'avènement des grandes civilisations. Au temps du tribalisme, Brokrand était une figure invoquée par les chefs de tribus ou leur chaman quand venait le temps de trancher un conflit. Maintenant une figure imposante dans la plupart des sociétés, Brokrand est un dieu souvent représenté comme un vieil homme de stature imposante, les autres détails variant de culte en culte. L'ordre et la justice sont les thèmes les plus récurrents chez ce dieu : il est rare qu'il soit considéré comme un dieu mineur.""
        },
        {
          ""title"": ""Eccani"",
          ""description"": ""Déesse aux multiples visages, les religions s'entendent peu sur le rôle exact de cette divinité. Sa représentation dans les écrits est aussi variable que son interprétation. La grande confusion provient du fait que le premier texte traitant de la déesse était dans un langage fort primitif, et le mot utilisé pour la décrire pouvait aussi bien se traduire par vie, fertilité ou nature. Ainsi, certains l'attribuent comme une déesse de la fertilité, d'autres de l'agriculture et même parfois comme une patronne des femmes. L'importance de cette déesse dans les religions varie grandement avec son rôle exact.""
        },
        {
          ""title"": ""Cesserak"",
          ""description"": ""Souvent représenté comme une ombre ailée ou un insecte menaçant, Cesserak est le dieu de la nuit, des ténèbres, mais aussi parfois de la nature ou du sacrifice. Certaines religions font de lui un antagoniste ennemi des mortels et des autres dieux, d'autres lui vouent un culte par respect ou par crainte. Les légendes veulent que Cesserak soit le patron des créatures nocturnes, ainsi plusieurs militaires assignés à des quarts de nuit vont porter un symbole le représentant pour obtenir sa clémence. Les sages ont confirmé que certaines créatures intelligentes de la nuit lui vouent un culte exclusif.""
        },
        {
          ""title"": ""Nox"",
          ""description"": ""Le grand et puissant Nox est un dieu dont l'interprétation demeure similaire d'une religion à l'autre. Nox est le dieu du courage et de la force, on le dit souvent le dieu des héros. Nox est peu représenté physiquement dans les écrits, bien qu'il arrive qu'il soit représenté en barbare ou en templier dépendamment des régions. Il n'est jamais décrit comme un stratège ou un soldat discipliné, et il encourage l'initiative personnelle à la guerre par ses enseignements.""
        },
        {
          ""title"": ""Malinkant"",
          ""description"": ""Le dieu-rat Malinkant, on dit, est à l'origine des pestes et des épidémies. C'est un dieu dont on craint le courroux et la plupart des religions lui font sacrifice pour implorer sa clémence. Certaines religions vont le relier à toutes les catastrophes naturelles, d'autres simplement à la maladie. Il est souvent aussi un dieu du crime et souvent placé en opposition avec Brokrand.""
        },
        {
          ""title"": ""Finosia"",
          ""description"": ""Dans les plus anciens écrits, les mots utilisés pour décrire la déesse Finosia sont déesse du cycle. Les interprétations de cette appellation sont vastes, mais la plupart des sages s'entendent pour une forte référence au cycle de la vie. Ainsi on la verra comme déesse de la mort, déesse de la vie, déesse de l'après-vie ou déesse de toutes ces choses à la fois. Sa représentation varie largement selon le rôle qu'on lui attribut.""
        },
        {
          ""title"": ""Nikatum"",
          ""description"": ""Ce dieu est souvent lié à la guerre et à la politique. On le dit le dieu le plus près du pouvoir des hommes, celui qui planifie la guerre et dirige les peuples par son influence indirecte. Nikatum est souvent représenté comme un tacticien humain ou comme un puissant géant. Les anciens textes racontent le temps où Nikatum marchait sur la terre des hommes. La conclusion de l'histoire a depuis longtemps disparu des annales de l'histoire, et chaque religion la complète par extrapolation ou par opportunisme.""
        },
        {
          ""title"": ""Le cosmos"",
          ""description"": ""Parfois vu comme un ensemble, parfois comme une divinité et autrefois comme une force, les anciens font référence au cosmos dans tous leurs récits religieux. Le cosmos peut être l'univers en soi, parfois un dieu réel et séparé mais à la fois englobant toutes choses et quelques fois même une simple force sans volonté propre de laquelle on tire un certain pouvoir. Le cosmos prend néanmoins une part très importante dans les religions du monde, c'est un élément mystique que l'on reconnaît comme essentiel à la solidité du monde.""
        },
        {
          ""title"": ""Les éléments"",
          ""description"": ""Depuis les premières théories sur les phénomènes naturels, on les a attribués au divin. Si certaines tribus primitives vouent un culte aux volcans mêmes ou aux tempêtes, toutes les religions vont relier la météo et les forces naturelles à un aspect divin, une volonté supérieure. Certaines religions y vouent une importance assez forte pour donner un aspect divin aux élémentaux et aux golems, ce que d'autres religions rejettent fortement. On peut tout de même considérer les éléments comme une force divine même s’ils ne sont pas toujours perçus comme un dieu en eux-mêmes.""
        },
        {
          ""title"": ""Les autres forces"",
          ""description"": ""Il existe nécessairement un grand nombre d'autres forces dans le monde qui sont soit spécifiques à une ou deux religions en particulier ou qui sont d'importance réduite. Tel est le cas des grandes castes extra planaires, comme les démons ou les anges. Ils ne sont pas toujours liés aux agendas des dieux, et souvent plutôt reliés à leurs propres desseins. Il est généralement admis que les anges et les démons sont en opposition, mais certaines religions postulent que ces créatures n'ont rien de divin et cherchent seulement à voler le cœur des hommes pour leurs desseins personnels.""
        }
      ]
    },
    {
      ""title"": ""Religions"",
      ""section"": [
        {
          ""title"": ""Le Maratisme"",
          ""description"": ""La religion Marat est une des grandes religions du monde. Elle repose sur les écrits du prophète Skéran qui, il y a près de deux millénaires, a retrouvé les anciennes tablettes religieuses de la tribu sainte de Marat, première à avoir eu un contact avec les dieux. La prétention de ce mouvement est d'être le plus près de la réalité de l'humanité."",
          ""section"": [
            {
              ""title"": ""Cosmologie"",
              ""description"": [
                ""Cette religion accorde une part aussi importante à Brokrand, reconnu comme le dieu de la justice, Finosia, déesse de la mort et Eccani, déesse de la vie. Cette religion donne une grande importance aux dieux humanoïdes et peu aux dieux qui s'éloignent des humains. Ainsi, Brokrand est représenté comme un vieil homme sage de grande stature portant de riches vêtements. Finosia devient une déesse plus sinistre mais toujours empreinte d'une grande humanité. Eccani est une déesse radieuse représentée comme une jeune femme de grande beauté."",
                ""Cette religion rejette fortement Cesserak et Malinkant comme agents aidant l’humanité. On attribut à Malinkant les catastrophes naturelles ainsi que tous les maux provenant de la nature, alors que tous les monstres proviennent du dieu-monstre Cesserak, qui utilise le couvert de la nuit pour cacher sa grande laideur. L'imaginaire Maratisme ne peut pas imaginer un mal qui provienne de leur propre structure sociale; le souverain devient alors une figure d'inspiration divine qui, bien qu'il ne dirige pas la religion, détient une certaine légitimité de celle-ci. On dit de Nikatum qu'il était le premier souverain des hommes, par mandat divin, et qu'à sa mort il fut amené dans le monde des dieux pour veiller sur les souverains des hommes. Le cosmos pour les maratistes est le vide, l'espace entre les étoiles, ce qui tient le monde ensemble. Il ne s'agit pas d'une force consciente, mais plutôt de l'énergie résiduaire des dieux.""
              ]
            },
            {
              ""title"": ""Hiérarchie"",
              ""description"": [
                ""Au niveau clérical, la religion Marat possède une hiérarchie très stricte. Le chef de la religion est le Grand Oracle, dont la fonction est de connaître la religion et d'interpréter celle-ci pour que son application englobe toutes choses. Sous lui se trouvent les Oracles, grand savants eux-aussi, qui ont pour tâche d'aider les souverains dans leurs décisions et de produire des études religieuses. En dessous des Oracles se trouvent les évêques, qui doivent transmettre le divin à la population dans les grands collèges de la religion Marat. Plus souvent qu'autrement, ces professeurs sont aussi savants dans un grand nombre de matières qui leur permettent de faire l'éducation complète des gens à leur charge. Les évêques font aussi le lien entre les officiants plus près du peuple et les Oracles. Finalement, la religion possède un certain nombre d’officiants mineurs qui varient selon les régimes."",
                ""Parallèle au clergé régulier se trouvent les templiers. Cette organisation est spécifique à la nation de Canavim et ne devrait pas être vue comme une normalité dans la foi. Les templiers sont des soldats pieux au service du régime qui sont capables de certains pouvoirs reliés normalement aux thaumaturges. Un templier doit suivre les enseignements de la foi, mais il ne peut pas non plus désobéir aux lois de sa patrie. Les templiers sont décrits en profondeur dans le document de classe et le document de Canavim.""
              ]
            },
            {
              ""title"": ""Dogme"",
              ""description"": [
                ""La religion Marat est une religion de peu de dogmes, les Oracles gardant le contrôle sur ce qui est acceptable ou non. Cette flexibilité dans la foi permet à cette religion de demeurer adaptable au contexte dans lequel elle se trouve, mais en un même temps donne un grand pouvoir idéologique au Grand Oracle. Il est fort rare pour un souverain de se mettre à dos le chef de la foi, car ses édits ont de grands impacts sur la population. Les édits qui n’ont jamais été modifiés tiennent surtout sur le comportement du croyant. Chacun se doit de porter secours au faible, de ne pas tuer par plaisir, de ne pas voler ou piller et toutes ces choses qui semblent faire partie d’un certain droit naturel. Le Maratisme a sa fête majeure au nouvel an et à la fête des ancêtres. La fête des ancêtres souligne le souvenir de ceux qui ont trépassé; on en profite souvent pour visiter la tombe des défunts qui nous sont proche."",
                ""Le Maratisme a un fort dogme entourant l’union de deux être dans le but de fonder une famille, ainsi que pour honorer ceux qui sont morts. Les mariages ne peuvent jamais avoir lieu pendant une période de grand malheur, cela est réputé mauvais pour la progéniture issue de l’union. Le mariage prend généralement la forme d’une cérémonie très grandiose qui regroupe famille et amis dans un banquet. Le mariage doit être béni par un officier de la foi ou un magistrat de l’État. Le Maratisme croit qu’à la mort, l’âme est dispersée dans le monde et finit par rejoindre les dieux. Pour cette raison, on n’enterre jamais les morts, car cela emprisonne leur âme. La méthode traditionnelle consiste à brûler le cadavre dans un immense feu sur lequel on prépare un repas pour les proches de la victime. Cette tradition étrange ne trouve pas vraiment écho ailleurs.""
              ]
            },
            {
              ""title"": ""Thaumaturgie"",
              ""description"": ""Les thaumaturges de cette religion peuvent suivre trois voies divines. Cette voie est choisie au moment de leur intronisation parmi les rangs des thaumaturges. Chacune des voies est une référence à un dieu majeur du culte. La voie première est la voie de la justice (Brokrand), la seconde la voie de la vie (Eccani), et la dernière la voie de la mort (Finosia).""
            }
          ]
        },
        {
          ""title"": ""Le Sravénisme"",
          ""description"": ""Le livre de Sravène fut découvert il y a plusieurs millénaires pendant l’ère du tribalisme. Le livre écrit avec du sang animal sur de l’écorce de bouleau n’a pas survécu jusqu’à notre ère, ne laissant derrière que des copies souvent modifiées par les différentes hérésies que cette religion a connues. Cette religion est la plus répandue sur le continent, car elle prend racine dans le plus profond de l’ère du tribalisme (Les tablettes de la tribu Marat furent découvertes après ce livre prophétique). Le Sravénisme est donc une religion très âgée, qui est resté ancrée dans les dogmes du passé."",
          ""section"": [
            {
              ""title"": ""Cosmologie"",
              ""description"": [
                ""L’attachement au divin est fort particulier pour cette religion. En effet, la religion n’a pas de concept de dieu bon ou mauvais, les dieux sont tous des esprits qui transcendent notre réalité et représentent de grands concepts. La cosmologie sravène donne une importance très marquée aux éléments et au cosmos ainsi qu’à un nombre de forces extérieures. Le cosmos s’inscrit comme la force créatrice qui guide le monde sur une voie précise qui échappe à l’imaginaire des mortels. C’est ainsi que la plupart des croyants de cette religion en viennent à la conclusion que nous avons tous un destin déterminé par le cosmos, mais qu’il nous est impossible de prévoir notre propre destin. La succession des saisons et les changements météo sont vus comme l’œuvre active et raisonnée du cosmos. Si une région est touchée par une catastrophe naturelle, on attribut cela à un bris du destin : les mortels avec leur volonté propre sont allés, bien malgré eux, contre la volonté du cosmos, et les catastrophes naturelles viennent réguler les erreurs des hommes. Pour cette raison, il existe certaines régions qui ne reconstruisent pas après qu’un sinistre ait détruit un bâtiment, supposant qu’il s’agissait de la volonté du cosmos."",
                ""Les dieux ont quand même leur part à jouer dans ce système. En effet, ceux-ci sont les esprits gardiens des hommes. Brokrand est le patron de la civilisation et du progrès, il dirige les nations sur la voie de la prospérité et de la sécurité. Eccani est la déesse de la fertilité, protégeant contre les fausses-couches et les mauvaises récoltes. Cesserak veille sur le sommeil des créatures diurnes et sur les créatures nocturnes. Nox est le patron des héros de la guerre et des combattants en général, il inspire le courage et le leadership. Malinkant est le dieu du mal nécessaire, celui qui brise le cycle lorsque nécessaire. Finosia est la déesse du cycle, accompagnant les mortels de leur naissance à leur putréfaction. Nikatum est le dieu du pouvoir, il veille sur les détenteurs du pouvoir et ceux qui peuvent améliorer l’État. On implore ces dieux lorsqu’une situation se rattachant à eux demande l’intervention du divin ou de la chance."",
                ""Le concept du cycle est très important pour la religion sravène. Il y a cette croyance que tout est cyclique : Si une nation tombe, alors une autre prendra sa place. Si une personne meurt, son corps et son esprit se retrouveront dans la nature et reviendront sous une autre forme. Le cycle est, en quelque sorte, une divinité en lui-même.""
              ]
            },
            {
              ""title"": ""Hiérarchie"",
              ""description"": ""La religion sravène n’a pas de clergé à proprement parler. Il existe des autorités en l’objet des livres religieux et il existe ceux qui savent et ceux qui ne savent pas. On nomme souvent sage celui qui connaît les livres religieux. Les sages sont présents dans les communautés et ils ne sont pas toujours thaumaturge (et vice-versa). Les gens du peuple qui sont très pieux se rapportent souvent à leur sage pour avoir des conseils sur comment ils devraient se comporter ou quand vient le temps de prendre de grandes décisions. Le sage devient le conseiller d’un peu tout le monde. Il n’existe pas de supérieur au sage, et même si certains jouissent d’un grand prestige, nul n’est tenu de prendre leurs conseils comme divins. Ils n’ont pas d’emprise sur le pouvoir autre que l’influence qu’ils arrivent à avoir sur le petit peuple par endroit. Leur pouvoir est proportionnel à leur capacité à mobiliser le peuple. Il arrive souvent que les sages plus influents se retrouvent en compétition pour savoir qui est le plus connaissant. Rares sont les guerres de ce genre qui en viennent au sang, mais cela n’est pas impossible.""
            },
            {
              ""title"": ""Dogme"",
              ""description"": [
                ""Le Sravénisme est lourd de dogmes et de fêtes. On fête l’arrivée du printemps avec la fête du renouveau pendant laquelle les jeunes sont à l’honneur. On fête l’arrivée de l’été avec le festival estival. On fête l’arrivée de l’hiver avec la fête des aïeuls où les plus vieux sont à l’honneur et finalement l’arrivée de l’automne avec la fête du cycle, l’automne étant considéré comme la fin du cycle des saisons. La religion étant très forte sur le concept du cycle, la mort est célébrée en enterrant le cadavre, permettant à son corps de rejoindre la nature. Pendant un enterrement, il est coutume de faire un grand exposé sur la vie du défunt. Il est très mal vu de parler des circonstances de sa mort. L’immersion est aussi une forme utilisée pour disposer d’un mort. L’union de deux personnes est généralement célébrée par un magistrat ou le sage de la communauté, quoi qu’il arrive que l’on cherche un thaumaturge pour bénir plus efficacement l’union."",
                ""Le Sravénisme interdit à ses membres de se nourrir d’une créature que l’on a tuée nous-mêmes, sauf si l’on vit en Hermite (bien qu’un Hermite soit généralement végétarien) ou que l’on est en situation de survie. Le Sravénisme interdit aussi de disposer du corps d’un animal ou d’une plante déracinée dans un milieu où elle ne pourra pas se décomposer et rejoindre la nature. Le Sravénisme est aussi très stricte sur la mécanique tribale. La hiérarchie des familles et des clans est fortement renforcée dans la religion et oblige le simple citoyen à se soumettre à la volonté du seigneur sauf en cas d’extrême oppression. Il vaut toujours mieux faire confiance au souverain local qu’à l’étranger. Le Sravénisme permet aussi l’esclavage, postulant que la liberté de l’homme doit être acquise par la victoire.""
              ]
            },
            {
              ""title"": ""Thaumaturgie"",
              ""description"": ""Les thaumaturges Sravènes sont fortement sollicités. Un thaumaturge gagne ses pouvoirs par la volonté du cosmos; il n’y a pas d’enseignement possible, seulement la découverte intérieure, ce qui rend le nombre très restreint. Bien qu’ils ne soient pas nécessairement sages, les thaumaturges sont des piliers de leur communauté et sont souvent portés à voyager beaucoup pour aider le plus de communautés possible. Le thaumaturge sravène est la seule personne qui a le droit de renverser le cycle de la vie par le moyen de la résurrection, bien que les nécromanciens soient tolérés dans certaines régions.""
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
