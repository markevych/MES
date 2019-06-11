import { Component, OnInit } from '@angular/core';
import { ProgramsService } from './programs.service';
import { Program } from 'src/app/models/program.model';

@Component({
  selector: 'app-programs',
  templateUrl: './programs.component.html',
  styleUrls: ['./programs.component.scss']
})
export class ProgramsComponent implements OnInit {
  programs: Program[];
  newProgramName: string;

  constructor(private programService: ProgramsService) { }

  ngOnInit() {
    this.getPrograms();
  }

  getPrograms() {    
    this.programService.getPrograms().subscribe(res => this.programs = res);
  }

  createProgram() {
    this.programService.createProgram(this.newProgramName).subscribe(res => this.getPrograms());
    this.newProgramName = "";
  }

  deleteProgram(programId: string) {
    this.programService.deleteProgram(programId).subscribe(res => this.getPrograms());
  }

}
