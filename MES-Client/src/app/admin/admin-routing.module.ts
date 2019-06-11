import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ProgramsComponent } from './programs/programs.component';
import { SubjectsComponent } from './programs/subjects/subjects.component';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot([
      { path: 'programs', component: ProgramsComponent },
      { path: 'programs/:programId', component: SubjectsComponent }
    ])
  ]
})
export class AdminRoutingModule { }
