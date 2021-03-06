import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { FarmComponent } from './farm/farm.component';
import { ChickenComponent } from './chicken/chicken.component';
import { FarmService } from './farm.service';
import { ChickenService } from './chicken.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    ChickenComponent,
    FarmComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'farm', component: FarmComponent },
      { path: 'chicken', component: ChickenComponent }
    ])
  ],
  providers: [FarmService, ChickenService, FarmComponent],
  bootstrap: [AppComponent]
})
export class AppModule { }
