import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { Router } from '@angular/router';
import { ChickenService } from './chicken.service';
import { Farm } from './farm';
import { FarmService } from './farm.service';
import { FarmComponent } from './farm/farm.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  providers: [FarmService, ChickenService]
})


export class AppComponent {
  title = 'app';
  allFarms: Farm[] = [];
  base: string = {} as string;

  constructor(private http: HttpClient, private farmserv: FarmService, private router: Router, @Inject('BASE_URL') baseUrl) {
    this.base = baseUrl;
    this.getFarms();
  }

  getFarms() {
    this.farmserv.getFarmsList(this.base)
      .subscribe(farmList => {
        this.allFarms = farmList;
        console.log(this.allFarms);
      })
  }
  
}
