domains
diseaseName=string
symptomName=symbol
symptomType=integer
query=string
reply=char

database
%xpositive(symptomName,symptomType)
xpositive(symptomName)
xnegative(symptomName)

database - diagnosis_db
diag(diseaseName, symptomName)


predicates

nondeterm run_system
start_diagnosis
reset_database %Clear facts

positive(query,symptomName) % i,i
negative(query,symptomName) %i,i
ask(query,symptomName,reply) %i,i,i
remember(symptomName,reply) %i,i

nondeterm diagnosis(diseaseName) %o
nondeterm symptom(symptomName) %i

%nondeterm symptom(symptomName,symptomType) %i,i
%nondeterm updateSymptomType(symptomName, symptomType) %i,o


nondeterm loadData().
nondeterm saveData().
nondeterm process(integer).
nondeterm symptoms(diseaseName).

clauses


loadData():- existfile("D:\diagnosis.txt"), consult("D:\diagnosis.txt",diagnosis_db).
loadData.

saveData():- save("D:\diagnosis.txt",diagnosis_db).


process(1):- write("\nEnter Disease: "), readln(D),
	     not(diag(D,_)),
	     symptoms(D), !.
process(1):- write("Disease already exist\n").

%process(2):- .

symptoms(D):- 
	     write("Enter the symptom of ", D , " "),
	     readln(String),
	     assert(diag(D,String), diagnosis_db),
	     write("Do you want to add another symptom ? ( y / n ) "),
	     readchar(Replay), write(Replay), nl,
       	     Replay='y',
       	     symptoms(D).
symptoms(_):- write("Disease added successfully :)\n").

%%%%%%%%%%%%%%%%%%%%%%%%
%%%%% Main Clauses %%%%%
%%%%%%%%%%%%%%%%%%%%%%%%

run_system:-
	write("*** Medical Diagnostic Expert System for Childhood Diseases ***\n"), nl, 
	loadData,
	
	write(" 1 - Add New Disease \n 2 - Explanation Facility \n"),
	readint(C), nl, nl,
	process(C),
	start_diagnosis,
	write("Would you like anthor conclusion?(y/n)"), nl,
	readchar(Replay), write(Replay), nl, nl,
	Replay='y',
	reset_database,
	run_system.
	
run_system:-
	saveData,
	write("\n\nThanks!"),nl.	
	
start_diagnosis:-
	diagnosis(Disease),!,
	write("\n<Diagnosis> The disease is ",Disease,".\n"),nl.
	
start_diagnosis:-
	write("\n<Diagnosis> Sorry, I am not able to diagnose the disease. Try again!"),nl.

reset_database:-
	retractall(xpositive(_)),
	%retractall(xpositive(_,_)),
	retractall(xnegative(_)).
	
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%% Questioning Engine %%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

positive(_,Symptom):-
	xpositive(Symptom),!.
	%xpositive(Symptom,_),!.
positive(Query,Symptom):-
	not(xnegative(Symptom)),
	ask(Query,Symptom,'y').

negative(_,Symptom):-
	xnegative(Symptom),!.
negative(Query,Symptom):-
	not(xpositive(Symptom)),
	%not(xpositive(Symptom,_)),
	ask(Query,Symptom,'n').

ask(Query,Symptom,Reply):-
	write(Query),
	readln(R), frontchar(R,Z,_),nl,
	remember(Symptom,Z),
	Reply=Z.
	
remember(Symptom,'y'):-
	assert(xpositive(Symptom)).
	%assert(xpositive(Symptom,0)).
remember(Symptom,'n'):-
	assert(xnegative(Symptom)).

%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%% Knowledge base %%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%

/*
% Symptoms with Types

updateSymptomType(Symptom, EnteredType):-
	write("Your choice number is "), readint(EnteredType),!,
	retract(xpositive(Symptom,_)),
	assert(xpositive(Symptom,EnteredType)).	

%Case(1). The symptom already exists in the database (i.e. previously asked)
%Problem. Re-asking the user about the symptom's types that have been previously asked. (Comment Case(1.1, 1.2, 1.3) and run the program to show up the problem)
%Case(1.1). Description: The symptom already exists with the same Type of the current testing disease. 
%           Decision: So, stop and return true.
symptom(Name, Type):-
	xpositive(Name, SavedType), SavedType = Type,!.
	
%Case(1.2). Description: The symptom already exists with a different Type of the current testing disease.
%	    Decision: So, stop and return false (fail).
symptom(Name, _):-
	xpositive(Name, _),!,fail.

%Case(1.3). Description: The symptom already exists with a negative answer (no).
%   	    Decision: So, stop and return false (fail).	Because all the symptoms with types are positive.
symptom(Name, _):-
	xnegative(Name),!,fail.


%Case(2): Description: The symptom doesnot exist in the database (i.e. not previously asked)
% 	  Decision: Ask user about it.
symptom(temp, Type):-
	Symptom=temp,
	positive("<?> Does your body temperature is abnormal? (y/n)",Symptom),
	write("<Types> Choose one of the following:"), nl,
	write("1- moderate to high temperature"), nl, 
	write("2- high and fast-rising temperature"), nl,
	updateSymptomType(Symptom, EnteredType),!,
	Type = EnteredType.		
*/

% Symptoms without Types	
symptom(runny_nose):-
	positive("<?> Do you have a runny_nose? (y/n)",runny_nose).

symptom(rash):-
	positive("<?> Do you have a brownish-pink rash? (y/n)",rash).

%temp
symptom(high_temp):-
	positive("<?> Do you have a high and fast rising temperature? (y/n)",high_temp).
	
symptom(harsh_cough):-
	positive("<?> Do you have a harsh, hacking cough? (y/n)",harsh_cough).
		
symptom(bloodshot_eyes):-
	positive("<?> Do you have bloodshot_eyes? (y/n)",bloodshot_eyes).
			
symptom(conjunctivitis):-
	positive("<?> Do you have a conjunctivitis (y/n)",conjunctivitis).
	
symptom(white_spots):-
	positive("<?> Do you have rosy skin areas with white spots inside cheeks? (y/n)", white_spots).

symptom(light):-
	positive("<?> Are your eyes sensitive to light? (y/n)",light).

%temp
symptom(mod_temp):-
	positive("<?> Do you have a moderate temperature? (y/n)",mod_temp).
	
%Negative			
symptom(saliva):-
	negative("<?> Do you have a normal salvia? (y/n)",saliva).
	
symptom(lymph):-
	positive("<?> Are the lymph nodes in the neck enlarged? (y/n)",lymph).

symptom(mouth):-
	positive("<?> Do you have an dry mouth? (y/n)",mouth).				
				
symptom(body_ache):-
	positive("<?> Do you have a strong body_ache? (y/n)",body_ache).

symptom(weakness):-
	positive("<?> Do you have a general weakness? (y/n)",weakness).
	
symptom(headache):-
	positive("<?> Do you have a severe headache? (y/n)",headache).
	
symptom(vomiting):-
	positive("<?> Do you have a vomiting? (y/n)",vomiting).
	
symptom(diarrhea):-
	positive("<?> Do you have diarrhea? (y/n)",diarrhea).
		
symptom(sore_throat):-
	positive("<?> Do you have a sore_throat? (y/n)",sore_throat).	
		
symptom(sneezing):-
	positive("<?> Do you have a sneezing? (y/n)",sneezing).
				
diagnosis("Measles"):-
	symptom(runny_nose),
	symptom(rash),
	symptom(high_temp), %symptom(temp, 2),
	symptom(harsh_cough),
	symptom(bloodshot_eyes),	
	symptom(conjunctivitis),
	symptom(white_spots),
	symptom(light).	

diagnosis("Mumps"):-
	symptom(mod_temp), %symptom(temp, 1),
	symptom(saliva),
	symptom(lymph),
	symptom(mouth).		
	
diagnosis("Flu"):-
	symptom(runny_nose),
	symptom(harsh_cough),
	symptom(conjunctivitis),
	symptom(body_ache),
	symptom(weakness),
	symptom(headache),
	symptom(vomiting),
	symptom(diarrhea),
	symptom(sore_throat),
	symptom(sneezing).
	
diagnosis("Meningitis"):-
	symptom(high_temp), %symptom(temp, 2),
	symptom(light),
	symptom(headache),
	symptom(vomiting).
	
goal
run_system.