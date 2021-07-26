import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { ChickenService } from '../chicken.service';

@Component({
    selector: 'app-chicken',
    templateUrl: './chicken.component.html',
    styleUrls: ['./chicken.component.css'],
    providers: [ChickenService]
})
/** Chicken component*/
export class ChickenComponent {
    /** Chicken ctor */
      constructor(private http: HttpClient, private chicken: ChickenService, @Inject('BASE_URL') baseUrl) {
    
        

  }


}
