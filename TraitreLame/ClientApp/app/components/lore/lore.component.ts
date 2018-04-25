import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';


@Component({
    selector: 'lore',
    templateUrl: './lore.component.html'
})
export class LoreComponent {
    public loreRoot: LoreRoot;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/SampleData/GenerateLore').subscribe(result => {
            this.loreRoot = result.json() as LoreRoot;
        }, error => console.error(error));
    }
}