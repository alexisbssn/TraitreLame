import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';


@Component({
    selector: 'lore',
    templateUrl: './manual.component.html'
})
export class ManualComponent {
    public manualRoot: ManualRoot;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/SampleData/GenerateManual').subscribe(result => {
            this.manualRoot = result.json() as ManualRoot;
        }, error => console.error(error));
    }
}

interface ManualRoot {
    manual: Section[];
}