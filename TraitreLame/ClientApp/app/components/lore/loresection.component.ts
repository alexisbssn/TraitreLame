import { Component, Input } from '@angular/core';

@Component({
    selector: 'lore-section',
    templateUrl: './loresection.component.html'
})
export class LoreSectionComponent {
    @Input()
    public lore: Lore;

    @Input()
    public depth: number;

    public isString(elem: any): boolean {
        return typeof elem === "string";
    }

    public isArray(elem: any): boolean {
        return elem[0] !== undefined;
    }

    public isMedia(elem: any): boolean {
        return (elem as Media).type !== undefined;
    }

    public isDefined(elem: any): boolean {
        return elem !== undefined;
    }
}