import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { NgForm } from '@angular/forms';
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
  base: string;
  FarmC: FarmComponent;
  FarmC2: FarmComponent;
  fFarm: Farm;
  
  constructor(private http: HttpClient, private farm: FarmComponent, private router: Router) {
    this.FarmC = farm;
    this.allFarms = this.FarmC.getFarms();
  }
  
  getFarm(farmId: number){
    this.FarmC2 = this.farm;
    this.fFarm = this.FarmC2.getFarm(farmId);
    this.router.navigate(['/farm'], {state: {id: farmId}})
    console.log(this.fFarm)
    
  }

  addFarm(form: NgForm){
    this.FarmC.addFarm(form);
  }
    
  

}
