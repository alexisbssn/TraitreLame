import { Component } from '@angular/core';

@Component({
    selector: 'counter',
    templateUrl: './character.component.html'
})
export class CharacterComponent {
    public currentCount = 0;

    public incrementCounter() {
        this.currentCount++;
    }
}
