import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CharacterComponent } from './components/character/character.component';
import { LoreComponent } from './components/lore/lore.component';
import { ManualComponent } from './components/manual/manual.component';
import { DynamicSectionComponent } from './components/dynamicsection/dynamicsection.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        CharacterComponent,
        FetchDataComponent,
        HomeComponent,
        LoreComponent,
        DynamicSectionComponent,
        ManualComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'character', component: CharacterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: 'lore', component: LoreComponent },
            { path: 'manual', component: ManualComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModuleShared {
}
