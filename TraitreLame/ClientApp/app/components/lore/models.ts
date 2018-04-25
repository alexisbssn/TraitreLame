interface Lore {
    title: string;
    description: any[]; // sometimes string, sometimes string[], sometimes Media
    section: Lore[];
}

interface Media {
    type: string;
    src: string;
}

interface LoreRoot {
    lore: Lore[];
}