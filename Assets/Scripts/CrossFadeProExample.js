var camera0 : Camera;
var camera1 : Camera;
var camera2: Camera;
var fadeTime = 2.0;
private var inProgress = false;
private var swap = false;

function Update () {
	/*if (Input.GetKeyDown("space")) {
		DoFade();
	}*/
}


function DoFade01 () {
	if (inProgress) return;
	inProgress = true;
	
	swap = !swap;
	yield ScreenWipe.use.CrossFadePro (camera0,camera1, fadeTime);
	inProgress = false;
}

function DoFade10 () {
    if (inProgress) return;
    inProgress = true;
	
    swap = !swap;
    yield ScreenWipe.use.CrossFadePro (camera1,camera0, fadeTime);
    inProgress = false;
}

function DoFade02 () {
    if (inProgress) return;
    inProgress = true;
	
    swap = !swap;
    yield ScreenWipe.use.CrossFadePro (camera0,camera2, fadeTime);
    inProgress = false;
}

function DoFade20 () {
    if (inProgress) return;
    inProgress = true;
	
    swap = !swap;
    yield ScreenWipe.use.CrossFadePro (camera2,camera0, fadeTime);
    inProgress = false;
}


function DoFade12 () {
    if (inProgress) return;
    inProgress = true;
	
    swap = !swap;
    yield ScreenWipe.use.CrossFadePro (camera1,camera2, fadeTime);
    inProgress = false;
}

function DoFade21 () {
    if (inProgress) return;
    inProgress = true;
	
    swap = !swap;
    yield ScreenWipe.use.CrossFadePro (camera2,camera1, fadeTime);
    inProgress = false;
}